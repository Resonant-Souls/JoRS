using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace JoRS.Homeward.Core
{
    [ExtendsFromMod(ModCompatibility.Homeward.Name)]
    [JITWhenModsEnabled(ModCompatibility.Homeward.Name)]
    public class JoRSHomewardConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        internal static JoRSHomewardConfig Instance;
        public override void OnChanged() => Instance = this;
        public override void OnLoaded() => Instance = this;

        [Header("LoadedContent")]

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Enchantments { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool EternityModeAccessories { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool Energizers { get; set; }

        [ReloadRequired]
        [DefaultValue(true)]
        public bool QualityOfLife { get; set; }
    }
}