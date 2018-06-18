using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Zengii : ModNPC //Reference off of this file, please.
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zengii");
            Main.npcCatchable[npc.type] = true;
        }

        public override void SetDefaults()
        {
            npc.width = 64;
            npc.height = 76;
            npc.damage = 0;
            npc.defense = 1;
            npc.lifeMax = 30;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.catchItem = (short)mod.ItemType("Zengii_I");
            npc.aiStyle = 7;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Bunny]; ;
            aiType = NPCID.Bunny; 
            animationType = NPCID.Bunny; 
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldHallow.Chance * 0.8f; 
        }
    }
}
