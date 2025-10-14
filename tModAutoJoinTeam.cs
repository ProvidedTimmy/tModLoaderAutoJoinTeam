// tModAutoJoinTeam.cs
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace tModAutoJoinTeam
{
    public class tModAutoJoinTeam : Mod { }

    public class tModAutoJoinTeam : ModPlayer
    {
        public override void OnEnterWorld(Player player)
        {
            var cfg = GetInstance<Config>();
            int team = cfg.TeamToJoin;
            if (team < 0 || team > 5) team = 5; // default pink team if out of range

            if (player.team != team)
            {
                player.team = team;

                // Sync all players in MP; No packet in SP
                if (Main.netMode == NetmodeID.MultiplayerClient || Main.netMode == NetmodeID.Server)
                    NetMessage.SendData(MessageID.PlayerTeam, -1, -1, null, player.whoAmI);
            }
        }
    }
}
