using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Flerpling : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flerpling");
        }

        public override void SetDefaults()
        {
            /* Removed as of 0.10
            //npc.name = "Gheraii";
            //npc.displayName = "Gheraii";
            */
            npc.width = 70;
            npc.height = 46;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 10;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath13;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 41;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Herpling]; //Main.npcFrameCount[5];
            aiType = NPCID.Herpling; // aiType = 174;
            animationType = NPCID.Herpling; // animationType = 174;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Crimson.Chance * 0.8f; 
        }
    }
}
