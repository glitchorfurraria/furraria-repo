using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.NPCs
{
    public class Cupi : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cupi");
        }

        public override void SetDefaults()
        {
            /* Removed as of 0.10
            //npc.name = "Cupi";
            //npc.displayName = "Cupi";
            */
            npc.width = 44;
            npc.height = 82;
            npc.damage = 4;
            npc.defense = 5;
            npc.lifeMax = 100;
            npc.noGravity = true; 
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 5;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.EaterofSouls]; //Main.npcFrameCount[3];
            aiType = NPCID.EaterofSouls;
            animationType = NPCID.EaterofSouls;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Corruption.Chance * 0.8f;
        }
        public override void NPCLoot()
        {
            {
                
             Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Gheraii_I")); 
            }

        }
    }
}
