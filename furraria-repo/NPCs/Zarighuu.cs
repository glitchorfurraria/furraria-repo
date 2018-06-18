using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Zarighuu : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zarighuu");
        }

        public override void SetDefaults()
        {
            npc.width = 52;
            npc.height = 54;
            npc.damage = 10;
            npc.defense = 20;
            npc.lifeMax = 500;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 85;
            npc.noGravity = true; // Not affected by gravity
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.StardustCellBig]; //Main.npcFrameCount[3];
            aiType = NPCID.StardustCellBig; // aiType = 7;
            animationType = NPCID.StardustCellBig; // animationType = 7;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.StardustTower.Chance * 0.8f; 
        }
    }
}
