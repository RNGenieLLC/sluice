using HarmonyLib;
using Vintagestory.API.Common;
using Vintagestory.API.Datastructures;
namespace Sluice.Inventory
{
    public class SluiceInventory : InventoryBase, IInventory
    {
        private ItemSlot[] slots;
        public ItemSlot[] Slots => slots;

        public ItemSlot InputSlot => slots[0];

        public SluiceInventory() : base(null, null)
        {
            slots = new ItemSlot[26];
            for (int i = 0; i < slots.Length; i++)
            {
                slots[i] = new ItemSlot(this);
            }
        }

        public override ItemSlot this[int slotId] { get => slots[slotId]; set => slots[slotId] = value; }

        public override int Count => slots.Length;

        public override void FromTreeAttributes(ITreeAttribute tree)
        {
            slots = SlotsFromTreeAttributes(tree, slots);
        }

        public override void ToTreeAttributes(ITreeAttribute tree)
        {
            SlotsToTreeAttributes(slots, tree);
        }

        // public bool AddItem(JsonItemStack jis)
        // {
        //     for (int i = 0; i < slots.Length; i++)
        //     {
        //         this.AddItem
        //         if (slots[i].Itemstack.Collectible.GetMergableQuantity(slots[i].Itemstack, jis.ResolvedItemstack, EnumMergePriority.AutoMerge) > 0)
        //         {
        //             slots[i].Itemstack.StackSize += jis.ResolvedItemstack.StackSize;
        //             return true;
        //         }
        //     }
        //     return false;
        // }

        public bool TryPutItemStack(ItemStack itemStack)
        {
            // first check if the item can be merged with an existing item
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].Empty)
                {
                    continue;
                }
                if (slots[i].Itemstack.Collectible.Code == itemStack.Collectible.Code)
                {
                    var mergableQuant = slots[i].Itemstack.Collectible.GetMergableQuantity(slots[i].Itemstack, itemStack, EnumMergePriority.AutoMerge);
                    if (mergableQuant != 0)
                    {
                        slots[i].Itemstack.StackSize += mergableQuant;
                        itemStack.StackSize -= mergableQuant;
                        if (itemStack.StackSize == 0)
                        {
                            return true;
                        }
                    }
                }
            }
            // if not, check if there is an empty slot
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].Empty)
                {
                    slots[i].Itemstack = itemStack;
                    return true;
                }
            }
            // if not, return false
            return false;
        }

        public void MarkDirty()
        {
            for (int i = 0; i < slots.Length; i++)
            {
                slots[i].MarkDirty();
            }
        }
    }
}