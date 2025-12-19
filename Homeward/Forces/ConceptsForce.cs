using FargowiltasSouls.Content.Items.Accessories.Forces;
using FargowiltasSouls.Core.Toggler.Content;
using JoRS.Homeward.Core;

namespace JoRS.Homeward.Forces
{
    [ExtendsFromMod(ModCompatibility.Homeward.Name)]
    [JITWhenModsEnabled(ModCompatibility.Homeward.Name)]
    public class ConceptsForce : BaseForce
    {
        public override bool IsLoadingEnabled(Mod mod) => JoRSHomewardConfig.Instance.Enchantments;
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
        //    Main.RegisterItemAnimation(Item.type, new DrawAnimationRectangularV(6, 2, 3));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;
            Enchants[Type] =
            [
                
            ];
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
        //    Item.width = 44;
        //    Item.height = 24;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SetActive(player);
        //    player.AddEffect<RogueKunai>(Item);
        //    player.AddEffect<MarksmanEffect>(Item);
        //    player.AddEffect<SunflowerEffect>(Item);
        //    player.AddEffect<WayfarerEffect>(Item);
        //    player.AddEffect<ElderbarkEffect>(Item);
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();

            foreach (int ench in Enchants[Type])
                recipe.AddIngredient(ench);

            recipe.AddTile(ModContent.Find<ModTile>("Fargowiltas", "CrucibleCosmosSheet"));
            recipe.Register();
        }
    }
    [ExtendsFromMod(ModCompatibility.Homeward.Name)]
    [JITWhenModsEnabled(ModCompatibility.Homeward.Name)]
    public class ConceptsForceEffect : AccessoryEffect
    {
        public override bool IsLoadingEnabled(Mod mod) => JoRSHomewardConfig.Instance.Enchantments;
        public override Header ToggleHeader => null;
    }
    [ExtendsFromMod(ModCompatibility.Homeward.Name)]
    [JITWhenModsEnabled(ModCompatibility.Homeward.Name)]
    public class ConceptsForceHeader : EnchantHeader
    {
        public override bool IsLoadingEnabled(Mod mod) => JoRSHomewardConfig.Instance.Enchantments;
        public override int Item => ModContent.ItemType<ConceptsForce>();
        public override float Priority => 1f;
    }
}