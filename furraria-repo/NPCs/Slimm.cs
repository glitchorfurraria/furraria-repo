using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Slimm : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimm");
        }

        public override void SetDefaults()
        {
            /* Removed as of 0.10
            //npc.name = "Slimm";
            //npc.displayName = "Slimm";
            */
            npc.width = 64;
            npc.height = 52;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 40;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 1;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime]; //Main.npcFrameCount[2];
            aiType = NPCID.BlueSlime; // aiType = 1;
            animationType = NPCID.BlueSlime; // animationType = 1;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.8f; 
        }
    }
}
