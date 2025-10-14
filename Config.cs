using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace tModLoaderAutoJoinTeam
{
    class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(5)]
        [Range(0, 5)]
        public int TeamToJoin;
    }
}
