using Sluice.BlockEntities;
using Sluice.Blocks;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;
using Sluice.Config;

namespace Sluice
{
    public class SluiceModSystem : ModSystem
    {

        public static SluiceModConfig ModConfig;

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from template mod: " + api.Side);
            api.RegisterBlockEntityClass(Mod.Info.ModID + ".BESluice", typeof(BESluice));
            api.RegisterBlockClass(Mod.Info.ModID + ".sluice", typeof(SluiceBlock));
            // api.StoreModConfig(new SluiceModConfig(), "modconfig.json");
            ModConfig = api.LoadModConfig<SluiceModConfig>("modconfig.json");
            if (ModConfig == null)
            {
                ModConfig = new SluiceModConfig();
                api.StoreModConfig(ModConfig, "modconfig.json");
            }
        }

    }
}
