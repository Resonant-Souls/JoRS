
using ContinentOfJourney.Items.Armor;
using FargowiltasSouls.Content.NPCs.EternityModeNPCs.VanillaEnemies.Snow;
using JoRS.Homeward.Core;
using JoRS.Homeward.Forces;

namespace JoRS.Homeward.Enchants
{
    [ExtendsFromMod(ModCompatibility.Homeward.Name)]
    [JITWhenModsEnabled(ModCompatibility.Homeward.Name)]
    public class FlinxFurEnchant : BaseEnchant
    {
        public override bool IsLoadingEnabled(Mod mod) => JoRSHomewardConfig.Instance.Enchantments;
        public override Color nameColor => new(255, 255, 255);
        public override void SetDefaults()
        {
            base.SetDefaults();
            Item.rare = ModContent.GetInstance<FlinxFurHat>().Item.rare;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddEffect<FlinxFurEffect>(Item);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<FlinxFurHat>()
                .AddIngredient(ItemID.FlinxFurCoat)
                .AddIngredient(ItemID.FlinxStaff)
                .AddIngredient(ItemID.SnowballCannon)
                .AddIngredient(ItemID.FrostDaggerfish)
                .AddIngredient(ItemID.SnowballLauncher)
                .AddTile<EnchantedTreeSheet>()
                .Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.Homeward.Name)]
    [JITWhenModsEnabled(ModCompatibility.Homeward.Name)]
    public class FlinxFurEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => JoRSHomewardConfig.Instance.Enchantments;
        public override Header ToggleHeader => Header.GetHeader<PowerForceHeader>();
        public override int ToggleItemType => ModContent.ItemType<FlinxFurEnchant>();
    }
}