using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class BigBatty : ModNPC //Reference off of this file, please.
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Big Batty");
        }

        public override void SetDefaults()
        {
            npc.width = 44;
            npc.height = 33;
            npc.damage = 5;
            npc.defense = 2;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 14;
            Main.hardMode = true;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GiantBat]; ;
            aiType = NPCID.GiantBat; 
            animationType = NPCID.GiantBat; 
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Cavern.Chance * 0.8f; 
        }
    }
}
