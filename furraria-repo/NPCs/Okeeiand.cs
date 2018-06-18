using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Okeeiand : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Okeeiand");
        }

        public override void SetDefaults()
        {
            npc.width = 75;
            npc.height = 64;
            npc.damage = 2;
            npc.defense = 2;
            npc.lifeMax = 80;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 3;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie]; //Main.npcFrameCount[3];
            aiType = NPCID.Crawdad; // aiType = 7;
            animationType = NPCID.Zombie; // animationType = 7;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.UndergroundJungle.Chance * 10f; 
        }
    }
}
