using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Batty : ModNPC //Reference off of this file, please.
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Batty");
            Main.npcCatchable[npc.type] = true;
        }

        public override void SetDefaults()
        {
            npc.width = 44;
            npc.height = 33;
            npc.damage = 4;
            npc.defense = 1;
            npc.lifeMax = 30;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.catchItem = (short)mod.ItemType("Batty_I");
            npc.aiStyle = 14;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.CaveBat]; ;
            aiType = NPCID.CaveBat; 
            animationType = NPCID.CaveBat; 
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Cavern.Chance * 0.8f; 
        }
    }
}
