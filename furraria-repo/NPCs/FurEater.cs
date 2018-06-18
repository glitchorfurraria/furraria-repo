using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class FurEater : ModNPC //Reference off of this file, please.
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fur Eater");
            Main.npcCatchable[npc.type] = true;
        }

        public override void SetDefaults()
        {
            npc.width = 64;
            npc.height = 76;
            npc.damage = 1;
            npc.defense = 1;
            npc.lifeMax = 30;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 13;
            npc.noGravity = true;
            npc.noTileCollide = true;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.ManEater]; ;
            aiType = NPCID.ManEater; 
            animationType = NPCID.ManEater; 
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.SurfaceJungle.Chance * 0.8f; 
        }
    }
}
