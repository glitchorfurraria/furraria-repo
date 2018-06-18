using Terraria.ModLoader;
using Terraria.ID;

namespace FurrariaMod.Items.Bars
{
    public class DecorellOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Decorell Ore");
            Tooltip.SetDefault("Decorate with it, or sellf it.");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("DecorellOreTile");
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}
