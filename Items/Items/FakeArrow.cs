using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace tstands.Items.Items
{
	public class FakeArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("An arrow made of stone and wood... Its oddly real looking.");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.melee = true;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
		item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 2f;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = (mod.GetLegacySoundSlot((SoundType)2, "Sounds/Item/swing"));
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe val = new ModRecipe(mod);
			val.AddIngredient(ItemID.Wood, 10);
			val.AddIngredient(ItemID.StoneBlock, 3);
			val.AddTile(TileID.WorkBenches);
			val.SetResult((ModItem)(object)this, 1);
			val.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			Random random = new Random();
			if (crit)
			{
				damage = damage * 2;
			}
			int num = random.Next(1, 2);
			Main.PlaySound(mod.GetLegacySoundSlot((SoundType)2, "Sounds/Item/fakearrowhit"), (item.position));
			damage *= num;
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.NextBool(3))
			{
				//Emit dusts when the sword is swung
				int num1 = Dust.NewDust(
		item.position,
		 item.width,
		 item.height,
		 DustID.Stone, //lazy number 6 for fire particles
		 item.velocity.X,
		 item.velocity.Y,
		 100, //alpha goes from 0 to 255
		 default(Color),
		 1f
		 );

				Main.dust[num1].noGravity = true;
				Main.dust[num1].velocity *= 0.1f;
			}
		}



	}
}
