using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;
using Cairo;
namespace Sluice.Gui
{
    public class SluiceGUI : GuiDialogBlockEntity
    {
        private long lastRedrawMs;
        public float currentBlockTime = 0;
        public SluiceGUI(InventoryBase inventory, BlockPos blockEntityPos, ICoreClientAPI capi) : base("Sluice", inventory, blockEntityPos, capi)
        {
            if (!base.IsDuplicate)
            {
                capi.World.Player.InventoryManager.OpenInventory(inventory);
                SetupDialog();
            }
        }

         private void SetupDialog()
        {
            ItemSlot itemSlot = capi.World.Player.InventoryManager.CurrentHoveredSlot;
            if (itemSlot != null && itemSlot.Inventory == base.Inventory)
            {
                capi.Input.TriggerOnMouseLeaveSlot(itemSlot);
            }
            else
            {
                itemSlot = null;
            }

            ElementBounds elementBounds = ElementBounds.Fixed(0.0, 0.0, 200.0, 90.0);
            ElementBounds bounds = ElementStdBounds.SlotGrid(EnumDialogArea.None, 0.0, 30.0, 1, 1);
            ElementBounds bounds2 = ElementStdBounds.SlotGrid(EnumDialogArea.None, 153.0, 30.0, 5, 5);
            ElementBounds elementBounds2 = ElementBounds.Fill.WithFixedPadding(GuiStyle.ElementToDialogPadding);
            elementBounds2.BothSizing = ElementSizing.FitToChildren;
            elementBounds2.WithChildren(elementBounds);
            ElementBounds bounds3 = ElementStdBounds.AutosizedMainDialog.WithAlignment(EnumDialogArea.RightMiddle).WithFixedAlignmentOffset(0.0 - GuiStyle.DialogToScreenPadding, 0.0);
            ClearComposers();
            base.SingleComposer = capi.Gui.CreateCompo("blockentitymillstone" + base.BlockEntityPosition, bounds3).AddShadedDialogBG(elementBounds2).AddDialogTitleBar(DialogTitle, OnTitleBarClose)
                .BeginChildElements(elementBounds2)
                .AddDynamicCustomDraw(elementBounds, OnBgDraw, "symbolDrawer")
                .AddItemSlotGrid(base.Inventory, SendInvPacket, 1, new int[1], bounds, "inputSlot")
                .AddItemSlotGrid(base.Inventory, SendInvPacket, 5, new int[25] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 }, bounds2, "outputslots")
                .EndChildElements()
                .Compose();
            lastRedrawMs = capi.ElapsedMilliseconds;
            if (itemSlot != null)
            {
                base.SingleComposer.OnMouseMove(new MouseEvent(capi.Input.MouseX, capi.Input.MouseY));
            }
        }

        private void OnTitleBarClose()
        {
            TryClose();
        }

        private void SendInvPacket(object p)
        {
            capi.Network.SendBlockEntityPacket(base.BlockEntityPosition.X, base.BlockEntityPosition.Y, base.BlockEntityPosition.Z, p);
        }

        private void OnBgDraw(Context ctx, ImageSurface surface, ElementBounds currentBounds)
        {
            double num = 30.0;
            ctx.Save();
            Matrix matrix = ctx.Matrix;
            matrix.Translate(GuiElement.scaled(63.0), GuiElement.scaled(num + 2.0));
            matrix.Scale(GuiElement.scaled(0.6), GuiElement.scaled(0.6));
            ctx.Matrix = matrix;
            capi.Gui.Icons.DrawArrowRight(ctx, 2.0);
            double num2 = currentBlockTime / 15;
            ctx.Rectangle(GuiElement.scaled(5.0), 0.0, GuiElement.scaled(125.0 * num2), GuiElement.scaled(100.0));
            ctx.Clip();
            LinearGradient linearGradient = new LinearGradient(0.0, 0.0, GuiElement.scaled(200.0), 0.0);
            linearGradient.AddColorStop(0.0, new Color(0.0, 0.4, 0.0, 1.0));
            linearGradient.AddColorStop(1.0, new Color(0.2, 0.6, 0.2, 1.0));
            ctx.SetSource(linearGradient);
            capi.Gui.Icons.DrawArrowRight(ctx, 0.0, strokeOrFill: false, defaultPattern: false);
            linearGradient.Dispose();
            ctx.Restore();
        }

        public void Update(float currentBlockTime)
        {
            this.currentBlockTime = currentBlockTime;
            if (IsOpened() && capi.ElapsedMilliseconds - lastRedrawMs > 100)
            {
                capi.Logger.Warning("Redrawing Sluice GUI");
                if (base.SingleComposer != null)
                {
                    capi.Logger.Warning("We have composer");
                    base.SingleComposer.GetCustomDraw("symbolDrawer").Redraw();
                }

                lastRedrawMs = capi.ElapsedMilliseconds;
            }
        }
    }
}