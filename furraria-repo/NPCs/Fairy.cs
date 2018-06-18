using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Fairy : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fairy");
            Main.npcCatchable[npc.type] = true;
        }

        public override void SetDefaults()
        {
            /* Removed as of 0.10
            //npc.name = "Gheraii";
            //npc.displayName = "Gheraii";
            */
            npc.width = 56;
            npc.height = 36;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 10;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.catchItem = (short)mod.ItemType("Fairy_I");
            npc.aiStyle = 22;
            npc.noGravity = true; // Not affected by gravity
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Pixie]; //Main.npcFrameCount[4];
            aiType = NPCID.Pixie; // aiType = 75;
            animationType = NPCID.Pixie; // animationType = 75;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldHallow.Chance * 0.8f; 
        }
    }
}
