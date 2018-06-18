using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class BlueLawwi : ModNPC //Reference off of this file, please.
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Lawwi");
            Main.npcCatchable[npc.type] = true;
        }

        public override void SetDefaults()
        {
            npc.width = 34;
            npc.height = 22;
            npc.damage = 0;
            npc.defense = 1;
            npc.lifeMax = 30;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.catchItem = (short)mod.ItemType("BLawwi_I");
            npc.aiStyle = 7;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.CyanBeetle]; ;
            aiType = NPCID.CyanBeetle; 
            animationType = NPCID.CyanBeetle; 
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldHallow.Chance * 0.8f; 
        }
    }
}
