using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class BigCattu : ModNPC //Reference off of this file, please.
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Big Cattu");
        }

        public override void SetDefaults()
        {
            npc.width = 46;
            npc.height = 46;
            npc.damage = 1;
            npc.defense = 10;
            npc.lifeMax = 300;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 13;
            Main.hardMode = true;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GiantFungiBulb]; ;
            aiType = NPCID.GiantFungiBulb; 
            animationType = NPCID.GiantFungiBulb; 
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.UndergroundMushroom.Chance * 0.8f; 
        }
    }
}
