using Vintagestory.API.Common;
using Sluice.Inventory;
using Sluice.Gui;
using Vintagestory.API.Client;
using Vintagestory.GameContent;
using System.Linq;
using System.Collections.Generic;
using Sluice;
using Sluice.Config;
using Vintagestory.API.Datastructures;
using HarmonyLib;
using Vintagestory.API.MathTools;
using Vintagestory.API.Util;
using System;

namespace Sluice.BlockEntities
{
    public class BESluice : BlockEntityOpenableContainer
    {
        private Dictionary<string, PanningDrop[]> dropsBySourceMat;
        public SluiceInventory inventory;
        public SluiceGUI gui;
        public float TimePerBlock = 15f;

        public BESluice()
        {
            inventory = new SluiceInventory();
            inventory.SlotModified += OnSlotModifid;
        }

        public override void Initialize(ICoreAPI api)
        {
            if (api == null)
            {
                return;
            }
            base.Initialize(api);
            RegisterGameTickListener(Every100ms, 100);
            dropsBySourceMat = Block.Attributes["panningDrops"].AsObject<Dictionary<string, PanningDrop[]>>();
            if (dropsBySourceMat == null)
            {
                Api.Logger.Debug("drop source mats not found using wood pan drop table");
                var block = Api.World.GetBlock(new AssetLocation("game:pan-wooden"));
                dropsBySourceMat = block.Attributes["panningDrops"].AsObject<Dictionary<string, PanningDrop[]>>();
            }
        }

        public override InventoryBase Inventory => inventory;

        public override string InventoryClassName => "sluiceinventory";

        //public override void Initialize(ICoreAPI api)
        //{
        //    base.Initialize(api);
        //}

        public override bool OnPlayerRightClick(IPlayer byPlayer, BlockSelection blockSel)
        {
            if (Api.Side == EnumAppSide.Client)
            {
                toggleInventoryDialogClient(byPlayer, delegate
                {
                    gui = new SluiceGUI(inventory, Pos, Api as ICoreClientAPI);
                    gui.Update(15 - TimePerBlock);
                    return gui;
                });
            }
            return true;
        }

        public void Every100ms(float dt)
        {
            if (!IsInWater())
            {
                return;
            }
            if (Api == null)
            {
                return;
            }

            if (inventory.InputSlot.Empty)
            {
                return;
            }

            if (inventory.InputSlot.Itemstack.StackSize <= 0)
            {
                return;
            }

            if (!IsCollectibleWorkable(inventory.InputSlot.Itemstack.Collectible))
            {
                return;
            }

            if (Api.Side != EnumAppSide.Client)
            {
                TimePerBlock -= dt;
                if (TimePerBlock <= 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        SluiceInput();
                    }
                    inventory.InputSlot.TakeOut(1);
                    inventory.MarkDirty();
                    TimePerBlock = Block.Attributes["sluiceTimePerBlock"].AsFloat();
                }
                MarkDirty();
            }
        }

        private ItemStack Resolve(EnumItemClass type, string code)
        {
            if (type == EnumItemClass.Block)
            {
                Block block = Api.World.GetBlock(new AssetLocation(code));
                if (block == null)
                {
                    Api.World.Logger.Error("Failed resolving panning block drop with code {0}. Will skip.", code);
                    return null;
                }

                return new ItemStack(block);
            }

            Item item = Api.World.GetItem(new AssetLocation(code));
            if (item == null)
            {
                Api.World.Logger.Error("Failed resolving panning item drop with code {0}. Will skip.", code);
                return null;
            }

            return new ItemStack(item);
        }

        protected void SluiceInput()
        {
            PanningDrop[] array = null;
            var fromBlockCode = inventory.InputSlot.Itemstack.Block.Code.ToShortString();
            if (fromBlockCode == null)
            {
                Api.Logger.Debug("Block Material Null");
            }
            foreach (string key in dropsBySourceMat.Keys)
            {
                if (WildcardUtil.Match(key, fromBlockCode))
                {
                    array = dropsBySourceMat[key];
                }
            }

            if (array == null)
            {
                throw new InvalidOperationException("Coding error, no drops defined for source mat " + fromBlockCode);
            }

            string newValue = Api.World.GetBlock(new AssetLocation(fromBlockCode))?.Variant["rock"];
            array.Shuffle(Api.World.Rand);
            for (int i = 0; i < array.Length; i++)
            {
                PanningDrop panningDrop = array[i];
                double num = Api.World.Rand.NextDouble();

                float num3 = panningDrop.Chance.nextFloat();
                panningDrop.Resolve(Api.World, "SluiceBlockEntity");
                ItemStack itemStack = panningDrop.ResolvedItemstack;
                if (array[i].Code.Path.Contains("{rocktype}"))
                {
                    itemStack = Resolve(array[i].Type, array[i].Code.Path.Replace("{rocktype}", newValue));
                }

                if (num < (double)num3 && itemStack != null)
                {
                    itemStack = itemStack.Clone();
                    if (!inventory.TryPutItemStack(itemStack))
                    {
                        Api.World.SpawnItemEntity(itemStack, Pos.ToVec3d());
                    }

                    break;
                }
            }
            // for (int rollIndex = 0; rollIndex < 8; rollIndex++)
            // {
            //     var jis = new JsonItemStack
            //     {
            //         Quantity = 1,
            //         Type = EnumItemClass.Item
            //     };
            //     var dropRoll = Api.World.Rand.NextSingle();
            //     if (dropRoll > 1 - SluiceModSystem.ModConfig.ChanceForDrop)
            //     {
            //         var roll = Api.World.Rand.NextSingle();

            //         var dropTable = SluiceModSystem.ModConfig.GetDropTableFromCode(inventory.InputSlot.Itemstack.Collectible.Code);
                    
            //         // Shuffle the drop table to eliminate bias from items with same drop rates
            //         var shuffledDropTable = dropTable.OrderBy(x => Api.World.Rand.Next()).ToList();
                    
            //         // Generate a random value between 0 and 1
            //         float randomValue = Api.World.Rand.NextSingle();
                    
            //         // Use weighted random selection - each item gets its own probability check
            //         CodeDropRates selectedDropRate = null;
                    
            //         foreach (var dropRate in shuffledDropTable)
            //         {
            //             // Each item gets an independent chance based on its drop rate
            //             if (randomValue <= dropRate.DropRate)
            //             {
            //                 selectedDropRate = dropRate;
            //                 break;
            //             }
            //         }
                    
            //         // If no item was selected (all failed their individual checks), 
            //         // randomly select from the table to ensure something drops
            //         if (selectedDropRate == null && shuffledDropTable.Count > 0)
            //         {
            //             int randomIndex = Api.World.Rand.Next(shuffledDropTable.Count);
            //             selectedDropRate = shuffledDropTable[randomIndex];
            //         }
                    
            //         // Update the JsonItemStack with the selected code
            //         if (selectedDropRate != null)
            //         {
            //             jis.Code = selectedDropRate.Code;
            //             jis.Type = selectedDropRate.Type;
            //             jis.Attributes = selectedDropRate.Attributes != null ? JsonObject.FromJson(selectedDropRate.Attributes.ToJsonToken()) : null;
            //         }
                    
            //         jis.Resolve(Api.World, "SluiceBlockEntity");

            //         // Item lookup failed just do not spawn
            //         if (jis.ResolvedItemstack == null)
            //         {
            //             continue;
            //         }
            //         if (!inventory.TryPutItemStack(jis.ResolvedItemstack))
            //         {
            //             BlockFacing blockFacing = BlockFacing.HORIZONTALS[1];
            //             Api.World.SpawnItemEntity(jis.ResolvedItemstack, Pos.ToVec3d().Add(0.5 + (double)blockFacing.Normalf.X * -0.7, 0.75, 0.5 + (double)blockFacing.Normalf.Z * 0.7), new Vec3d(blockFacing.Normalf.X * 0.02f, 0.0, blockFacing.Normalf.Z * 0.02f));
            //         }
            //     }
            // }
        }

        protected bool IsCollectibleWorkable(CollectibleObject collectible)
        {
            var shortCode = collectible.Code.ToShortString();
            return shortCode.StartsWith("bonysoil") || shortCode.StartsWith("muddygravel") || shortCode.StartsWith("sand") || shortCode.StartsWith("gravel");
        }

        private bool IsWaterBlock(Block block)
        {
            return block.Code.Path.Contains("water") || block.Code.Path.Contains("flowingwater");
        }

        protected bool IsInWater()
        {
            // Check the block below and adjacent blocks for water
            Block belowBlock = Api.World.BlockAccessor.GetBlock(Pos.DownCopy());
            Block northBlock = Api.World.BlockAccessor.GetBlock(Pos.NorthCopy());
            Block southBlock = Api.World.BlockAccessor.GetBlock(Pos.SouthCopy());
            Block eastBlock = Api.World.BlockAccessor.GetBlock(Pos.EastCopy());
            Block westBlock = Api.World.BlockAccessor.GetBlock(Pos.WestCopy());
            
            return IsWaterBlock(belowBlock) || IsWaterBlock(northBlock) || 
                   IsWaterBlock(southBlock) || IsWaterBlock(eastBlock) || 
                   IsWaterBlock(westBlock);
        }

        private void OnSlotModifid(int slotid)
        {
            if (Api is ICoreClientAPI)
            {
                gui.Update(15 - TimePerBlock);
            }

            // 0 is the input slot
            if (slotid == 0)
            {
                if (inventory.InputSlot.Empty)
                {
                    TimePerBlock = 15f;
                }

                MarkDirty();
                if (gui != null && gui.IsOpened())
                {
                    gui.SingleComposer.ReCompose();
                }
            }
        }

        public override void ToTreeAttributes(ITreeAttribute tree)
        {
            base.ToTreeAttributes(tree);
            ITreeAttribute treeAttribute = new TreeAttribute();
            inventory.ToTreeAttributes(treeAttribute);
            tree["inventory"] = treeAttribute;
            tree.SetFloat("TimePerBlock", TimePerBlock);
        }

        public override void FromTreeAttributes(ITreeAttribute tree, IWorldAccessor worldForResolving)
        {
            base.FromTreeAttributes(tree, worldForResolving);
            inventory.FromTreeAttributes(tree.GetTreeAttribute("inventory"));
            TimePerBlock = tree.GetFloat("TimePerBlock");
            if (worldForResolving.Side == EnumAppSide.Client && gui != null)
            {
                gui.Update(15 - TimePerBlock);
            }
        }
    }
}