using Terraria.ModLoader;
using Terraria.ID;
using FurrariaMod.NPCs;

namespace FurrariaMod.Items.Critters
{
    public class Zengii_I : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zengii");
            Tooltip.SetDefault("A hardmode critter.");
        }

        public override void SetDefaults()
        {
            item.width = 64; 
            item.height = 76; 
            item.useTime = 20; 
            item.useAnimation = 20; 
            item.useStyle = 0; 
            item.value = 00 | 00 | 10 | 50; 
            item.rare = 3; 
            item.UseSound = SoundID.Item1; 
            item.autoReuse = true; 
            item.consumable = true; 
            item.makeNPC = (short)mod.NPCType("Zengii");
            item.maxStack = 99; 
        }
    }
}
