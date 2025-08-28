using Sluice.BlockEntities;
using Sluice.Blocks;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;
using Vintagestory.API.Datastructures;
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
            // ModConfig = api.LoadModConfig<SluiceModConfig>("modconfig.json");
            if (ModConfig == null)
            {
                ModConfig = new SluiceModConfig();
                api.StoreModConfig(ModConfig, "modconfig.json");
            }
            else
            {
                // Check and update missing attributes for existing configs
                CheckAndUpdateLoreBookAttributes(api);
            }
        }

        /// <summary>
        /// Checks for the 4 lore book drops in BoneySoilDrop table and adds their attributes if missing.
        /// This ensures existing mod installations get the new attributes.
        /// </summary>
        private void CheckAndUpdateLoreBookAttributes(ICoreAPI api)
        {
            bool configUpdated = false;
            
            // Define the 4 lore books and their expected attributes
            var loreBooksToCheck = new[]
            {
                new { Code = "game:lore-book-aged-brickred", Category = "tobias" },
                new { Code = "game:lore-book-aged-cherryred", Category = "research" },
                new { Code = "game:lore-book-aged-darkbeige", Category = "diaries" },
                new { Code = "game:lore-book-aged-darkgray", Category = "jonas" }
            };

            foreach (var loreBook in loreBooksToCheck)
            {
                var existingDrop = ModConfig.BoneySoilDropRates.Find(drop => 
                    drop.Code?.ToShortString() == loreBook.Code);
                
                if (existingDrop != null)
                {
                    // Check if attributes are missing or if the category attribute is missing
                    if (existingDrop.Attributes == null || 
                        existingDrop.Attributes.GetString("category") != loreBook.Category)
                    {
                        // Create new attributes with the correct category
                        var newAttributes = new TreeAttribute();
                        newAttributes.Set("category", new StringAttribute(loreBook.Category));
                        existingDrop.Attributes = newAttributes;
                        
                        configUpdated = true;
                        Mod.Logger.Notification($"Updated attributes for {loreBook.Code} with category '{loreBook.Category}'");
                    }
                }
            }

            // Save the updated config if any changes were made
            if (configUpdated)
            {
                api.StoreModConfig(ModConfig, "modconfig.json");
                Mod.Logger.Notification("Updated mod config with missing lore book attributes");
            }
        }
    }
}
