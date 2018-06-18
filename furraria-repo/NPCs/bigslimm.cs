using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FurrariaMod.NPCs 
{
    [AutoloadBossHead]
    public class bigslimm : ModNPC
    {
        private Player player;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Big Slimm");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.aiStyle = 15;
            npc.lifeMax = 10000; // The Max HP the boss has on Normal
            npc.damage = 40; // The base damage value the boss has on Normal
            npc.defense = 30; // The base defense on Normal
            npc.knockBackResist = 0f; // No knockback
            npc.width = 174;
            npc.height = 120;
            npc.value = 10000;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.KingSlime];
            npc.npcSlots = 1f; // The higher the number, the more NPC slots this NPC takes.
            npc.boss = true; // Is a boss
            npc.lavaImmune = true; // Not hurt by lava
            npc.noGravity = false; // Not affected by gravity
            npc.noTileCollide = false; // Will not collide with the tiles. 
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            aiType = NPCID.KingSlime;
            music = MusicID.Boss2;
            bossBag = mod.ItemType("DecorellBar");
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense + numPlayers);
        }

        public override void AI()
        {
            Target(); // Sets the Player Target

            DespawnHandler(); // Handles if the NPC should despawn.
        }

        private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }

        private void DespawnHandler()
        {
            if(!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if(!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, -10f);
                    if(npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
            }
        }

        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                npc.DropBossBags();
            } else
            {
                if (Main.rand.Next(3) == 0) // For items that you want to have a chance to drop 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DecorellOre"));
                }
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DecorellBar")); // For Items that you want to always drop
            }

        }

        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }
        
    }
}
