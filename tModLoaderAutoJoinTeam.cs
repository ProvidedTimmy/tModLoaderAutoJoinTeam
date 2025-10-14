using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace tModLoaderAutoJoinTeam
{
    public class TModLoaderAutoJoinTeam : Mod { }

    public class TModAutoJoinTeam : ModPlayer
    {
        public override void OnEnterWorld()
        {
            var cfg = GetInstance<Config>();
            int team = cfg.TeamToJoin;
            if (team < 0 || team > 5) team = 5; // default pink team if out of range

            if (Player.team != team)
            {
                Player.team = team;

                // Sync all players in MP
                if (Main.netMode == NetmodeID.MultiplayerClient || Main.netMode == NetmodeID.Server)
                    NetMessage.SendData(MessageID.PlayerTeam, -1, -1, null, Player.whoAmI);
            }
        }
    }
}
