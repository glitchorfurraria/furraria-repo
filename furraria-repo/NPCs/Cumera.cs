using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Cumera : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cumera");
        }

        public override void SetDefaults()
        {
            /* Removed as of 0.10
            //npc.name = "Gheraii";
            //npc.displayName = "Gheraii";
            */
            npc.width = 42;
            npc.height = 80;
            npc.damage = 4;
            npc.defense = 5;
            npc.lifeMax = 100;
            npc.noGravity = true;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 5;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Crimera]; //Main.npcFrameCount[3];
            aiType = NPCID.Crimera; // aiType = 173;
            animationType = NPCID.Crimera; // animationType = 173;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Crimson.Chance * 0.8f; 
        }
    }
}
