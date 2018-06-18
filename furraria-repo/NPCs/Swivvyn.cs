using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Swivvyn : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swivvyn");
        }

        public override void SetDefaults()
        {
            npc.width = 100;
            npc.height = 94;
            npc.damage = 0;
            npc.defense = 2;
            npc.lifeMax = 75;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 14;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy]; //Main.npcFrameCount[4];
            aiType = NPCID.Harpy; // aiType = 48;
            animationType = NPCID.Harpy; // animationType = 48;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDay.Chance * 0.8f; 
        }
    }
}
