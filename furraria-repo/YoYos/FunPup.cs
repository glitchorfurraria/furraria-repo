﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.YoYos
{
    public class FunPup : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fun Pup");
        }

        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.aiStyle = 99; // All Yoyos use the style 99.
            projectile.friendly = false; // Doesn't harm NPCs
            projectile.penetrate = 1; // -1 = Will not go through enemy.
            projectile.melee = true; // The projectile is a melee projectile.
            projectile.damage = 25;
            projectile.scale = 1f; // The scale of the projectile. 2f is double size. 0.5f is half size.
            ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 3.5f;
            ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 300f;
            ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 13f;
        }
    }
}
