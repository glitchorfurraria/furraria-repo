using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Roblot : ModNPC // ModNPC is used for Custom NPCs
    {
        private Player player;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Roblot");
        }

        public override void SetDefaults()
        {
            /* Removed as of 0.10
            //npc.name = "Gheraii";
            //npc.displayName = "Gheraii";
            */
            npc.width = 80;
            npc.height = 46;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 10;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.noGravity = true;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 14;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.FlyingSnake]; //Main.npcFrameCount[3];
            aiType = NPCID.FlyingSnake; // aiType = 152;
            animationType = NPCID.FlyingSnake; // animationType = 152;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.JungleTemple.Chance * 0.8f;
        }
        private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }
    }
}
