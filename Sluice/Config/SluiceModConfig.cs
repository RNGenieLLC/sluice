using System.Collections.Generic;
using Vintagestory.API.Common;
using Vintagestory.API.Datastructures;

namespace Sluice.Config
{
    public class SluiceModConfig
    {
        public float SluiceSpeed = 1f;
        public float ChanceForDrop = 0.25f;
        public List<CodeDropRates> BoneySoilDropRates = new()
        {
            // new CodeDropRates { Code = new AssetLocation("game:lore-book-aged-brickred"), DropRate = 1f, Type = EnumItemClass.Item, Attributes = new TreeAttribute().Set("category", new StringAttribute("tobias")) },
             new CodeDropRates { Code = new AssetLocation("game:bone"), DropRate = 0.25f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:flaxtwine"), DropRate = 0.15f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:gear-rusty"), DropRate = 0.1f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:bonyremains-ribcage"), DropRate = 0.02f, Type = EnumItemClass.Block },
             new CodeDropRates { Code = new AssetLocation("game:candle"), DropRate = 0.06f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:gem-emerald-rough"), DropRate = 0.016f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:gem-olivine_peridot-rough"), DropRate = 0.016f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:gem-diamond-rough"), DropRate = 0.01f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:chutesection-copper"), DropRate = 0.009f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:metal-scraps"), DropRate = 0.016f, Type = EnumItemClass.Block },
             new CodeDropRates { Code = new AssetLocation("game:metal-parts"), DropRate = 0.011f, Type = EnumItemClass.Block },
             new CodeDropRates { Code = new AssetLocation("game:torchholder-aged-empty-north"), DropRate = 0.009f, Type = EnumItemClass.Block },
             new CodeDropRates { Code = new AssetLocation("game:nugget-nativegold"), DropRate = 0.16f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:nugget-nativesilver"), DropRate = 0.16f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:spearhead-copper"), DropRate = 0.011f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:nugget-hematite"), DropRate = 0.06f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:nugget-ilmenite"), DropRate = 0.03f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:stone-meteorite-iron"), DropRate = 0.03f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:nugget-chromite"), DropRate = 0.02f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:arrowhead-tinbronze"), DropRate = 0.06f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:spearhead-tinbronze"), DropRate = 0.01f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:arrowhead-copper"), DropRate = 0.08f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:lore-book-aged-brickred"), DropRate = 0.005f, Type = EnumItemClass.Item, Attributes = new TreeAttribute().Set("category", new StringAttribute("tobias")) },
             new CodeDropRates { Code = new AssetLocation("game:lore-book-aged-cherryred"), DropRate = 0.005f, Type = EnumItemClass.Item, Attributes = new TreeAttribute().Set("category", new StringAttribute("research")) },
             new CodeDropRates { Code = new AssetLocation("game:lore-book-aged-darkbeige"), DropRate = 0.005f, Type = EnumItemClass.Item, Attributes = new TreeAttribute().Set("category", new StringAttribute("diaries")) },
             new CodeDropRates { Code = new AssetLocation("game:lore-book-aged-darkgray"), DropRate = 0.005f, Type = EnumItemClass.Item, Attributes = new TreeAttribute().Set("category", new StringAttribute("jonas")) },
             new CodeDropRates { Code = new AssetLocation("game:gear-temporal"), DropRate = 0.005f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:metallamellae-copper"), DropRate = 0.003f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:metallamellae-tinbronze"), DropRate = 0.0015f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:metalchain-copper"), DropRate = 0.003f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:metalchain-tinbronze"), DropRate = 0.0015f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:metalplate-copper"), DropRate = 0.001f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:metalplate-tinbronze"), DropRate = 0.003f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:metalplate-iron"), DropRate = 0.001f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-1"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-2"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-3"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-4"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-5"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-6"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-7"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-8"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:tuningcylinder-9"), DropRate = 0.0008f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("resonator-north"), DropRate = 0.00015f, Type = EnumItemClass.Block },
             new CodeDropRates { Code = new AssetLocation("game:clothes-neck-golden-necklace"), DropRate = 0.0006f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:clothes-neck-bronze-gem-necklace"), DropRate = 0.0006f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:clothes-arm-bronze-armlet"), DropRate = 0.0018f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:clothes-arm-silver-chain"), DropRate = 0.0006f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:clothes-head-silver-diadem"), DropRate = 0.0006f, Type = EnumItemClass.Item },
             new CodeDropRates { Code = new AssetLocation("game:clothes-head-gold-coronet"), DropRate = 0.0006f, Type = EnumItemClass.Item }
        };
        public List<CodeDropRates> SandAndGravelDropRate = new()
        {
            new CodeDropRates { Code = new AssetLocation("game:stone-halite"), DropRate = 0.075f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:stone-chalk"), DropRate = 0.15f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:nugget-nativecopper"), DropRate = 0.2f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:nugget-sphalerite"), DropRate = 0.05f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:nugget-bismuthinite"), DropRate = 0.06f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:nugget-galena"), DropRate = 0.09f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:nugget-nativegold"), DropRate = 0.035f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:nugget-nativesilver"), DropRate = 0.035f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:nugget-cassiterite"), DropRate = 0.045f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:clay-blue"), DropRate = 0.1f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:clay-fire"), DropRate = 0.1f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:flint"), DropRate = 0.035f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:crystalizedore-rich-nativecopper-andesite"), DropRate = 0.0045f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:crystalizedore-rich-galena-claystone"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-quartz"), DropRate = 0.0375f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:clearquartz"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-lignite"), DropRate = 0.03f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-bituminouscoal"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-anthracite"), DropRate = 0.01f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-lapislazuli"), DropRate = 0.01f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-cinnabar"), DropRate = 0.01f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-sulfur"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-borax"), DropRate = 0.01f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-alum"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:ore-sylvite"), DropRate = 0.01f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:gear-rusty"), DropRate = 0.0055f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:metal-parts"), DropRate = 0.0025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:metal-scraps"), DropRate = 0.0025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:bonyremains-ribcage"), DropRate = 0.00075f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:gear-temporal"), DropRate = 0.00075f, Type = EnumItemClass.Item }
        };
        public List<CodeDropRates> MuddyGravelDropRate = new()
        {
            new CodeDropRates { Code = new AssetLocation("game:sapling-greenbamboo-free"), DropRate = 0.08f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:sapling-brownbamboo-free"), DropRate = 0.07f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-smallberrybush-cranberry-empty"), DropRate = 0.1f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-smallberrybush-blueberry-empty"), DropRate = 0.1f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-bigberrybush-redcurrant-empty"), DropRate = 0.1f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-bigberrybush-blackcurrant-empty"), DropRate = 0.1f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-bigberrybush-whitecurrant-empty"), DropRate = 0.06f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seashell-scallop-latte"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-sundial-latte"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-turritella-latte"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-clam-latte"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-conch-latte"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-seastar-latte"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-volute-latte"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-scallop-plain"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-sundial-plain"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-turritella-plain"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-clam-plain"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-conch-plain"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-seastar-plain"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-volute-plain"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-scallop-seafoam"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-sundial-seafoam"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-turritella-seafoam"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-clam-seafoam"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-conch-seafoam"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-seastar-seafoam"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-volute-seafoam"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-scallop-darkpurple"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-sundial-darkpurple"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-turritella-darkpurple"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-clam-darkpurple"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-conch-darkpurple"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-seastar-darkpurple"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-volute-darkpurple"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-scallop-cinnamon"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-sundial-cinnamon"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-turritella-cinnamon"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-clam-cinnamon"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-conch-cinnamon"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-seastar-cinnamon"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-volute-cinnamon"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-scallop-turquoise"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-sundial-turquoise"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-turritella-turquoise"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-clam-turquoise"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-conch-turquoise"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-seastar-turquoise"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("game:seashell-volute-turquoise"), DropRate = 0.00025f, Type = EnumItemClass.Block },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-catmint-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-forgetmenot-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-edelweiss-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-horsetail-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-heather-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-wilddaisy-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-orangemallow-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-westerngorse-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-cowparsley-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-lilyofthevalley-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-lupine-blue-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-lupine-orange-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-lupine-purple-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-lupine-red-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-lupine-white-free"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-small-crimson-green"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-small-crimson-brown-green"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-small-crimson-orange"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-small-darkgreen-gold"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-small-darkgreen-gold-crimson"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-small-green-orange"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-small-lemongreen"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-small-lemongreen-crimson"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-medium-crimson-green"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-medium-crimson-brown-green"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-medium-crimson-orange"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-medium-darkgreen-gold"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-medium-darkgreen-gold-crimson"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-medium-green-orange"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-medium-lemongreen"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-croton-medium-lemongreen-crimson"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-rafflesia-brown"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("wildfarmingrevival:wildseeds-flower-rafflesia-red"), DropRate = 0.005f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-acacia"), DropRate = 0.02f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-birch"), DropRate = 0.035f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-kapok"), DropRate = 0.025f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-maple"), DropRate = 0.03f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-oak"), DropRate = 0.03f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-pine"), DropRate = 0.03f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-darkpine"), DropRate = 0.025f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-larch"), DropRate = 0.0225f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-crimsonkingmaple"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-redwood"), DropRate = 0.02f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-greenspirecypress"), DropRate = 0.02f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-baldcypress"), DropRate = 0.03f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-ebony"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-walnut"), DropRate = 0.025f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:treeseed-purpleheart"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-carrot"), DropRate = 0.025f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-flax"), DropRate = 0.025f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-onion"), DropRate = 0.02f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-spelt"), DropRate = 0.02f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-turnip"), DropRate = 0.02f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-parsnip"), DropRate = 0.02f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-rice"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-rye"), DropRate = 0.025f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-soybean"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-pumpkin"), DropRate = 0.01f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-cabbage"), DropRate = 0.012f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-sunflower"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-cassava"), DropRate = 0.015f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-amaranth"), DropRate = 0.02f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-peanut"), DropRate = 0.0125f, Type = EnumItemClass.Item },
            new CodeDropRates { Code = new AssetLocation("game:seeds-pineapple"), DropRate = 0.01f, Type = EnumItemClass.Item }
        };

        public List<CodeDropRates> GetDropTableFromCode(AssetLocation code)
        {
            var codeString = code.ToShortString();
            if (codeString.StartsWith("bonysoil"))
            {
                return BoneySoilDropRates;
            }
            else if (codeString.StartsWith("muddygravel"))
            {
                return MuddyGravelDropRate;
            }
            else if (codeString.StartsWith("sand"))
            {
                return SandAndGravelDropRate;
            }
            else if (codeString.StartsWith("gravel"))
            {
                return SandAndGravelDropRate;
            }
            return SandAndGravelDropRate;
        }
    }

    public class CodeDropRates
    {
        public AssetLocation Code;
        public float DropRate;
        // Block or Item
        public EnumItemClass Type;
        public ITreeAttribute Attributes;
    }
}
