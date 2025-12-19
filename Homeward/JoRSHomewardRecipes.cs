using JoRS.Homeward.Core;

namespace JoRS.Homeward
{
    [ExtendsFromMod(ModCompatibility.Homeward.Name)]
    [JITWhenModsEnabled(ModCompatibility.Homeward.Name)]
    public class JoRSHomewardRecipes : ModSystem
    {
        public override void PostSetupRecipes()
        {
            for (int i = 0; i < Main.recipe.Length; i++)
            {
                Recipe recipe = Main.recipe[i];
                

                #region Enchantments

                if (JoRSHomewardConfig.Instance.Enchantments)
                {
                    if (recipe.createItem.type == ModContent.ItemType<SnowEnchant>() && recipe.HasIngredient(ItemID.FlinxFurCoat) && !recipe.HasIngredient(ItemID.IceBoomerang))
                    {
                        recipe.RemoveIngredient(ItemID.FlinxFurCoat);
                        recipe.AddIngredient(ItemID.IceBoomerang);
                    }
                }

                #endregion Enchantments
            }
        }
    }
}