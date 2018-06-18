using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Gheraii : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gheraii");
            Main.npcCatchable[npc.type] = true;
        }

        public override void SetDefaults()
        {
            /* Removed as of 0.10
            //npc.name = "Gheraii";
            //npc.displayName = "Gheraii";
            */
            npc.width = 64;
            npc.height = 64;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 10;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.catchItem = (short)mod.ItemType("Gheraii_I");
            npc.aiStyle = 7;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Bunny]; //Main.npcFrameCount[3];
            aiType = NPCID.Bunny; // aiType = 7;
            animationType = NPCID.Bunny; // animationType = 7;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Cavern.Chance * 0.8f; 
        }
    }
}
