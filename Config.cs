// Config.cs
using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace tModAutoJoinTeam
{
    class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [DefaultValue(1)]
        [Label("Team to Auto-Join")]
        [Tooltip("0=None, 1=Red, 2=Green, 3=Blue, 4=Yellow, 5=Pink")]
        [Range(0, 5)]
        public int TeamToJoin;
    }
}
