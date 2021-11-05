using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader.Config;

namespace tstands
{
	public class Server : ModConfig
	{
		public override ConfigScope Mode => (ConfigScope)0;

		[Label("Temp")]
		[Tooltip("Temp")]
		[ReloadRequired]
		public bool Temp1 { get; set; }

		[Label("Temp2")]
		public bool Temp2 { get; set; }

		[Label("Temp3")]
		[Tooltip("Temp3")]
		public List<ItemDefinition> player { get; set; } = new List<ItemDefinition>();


		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
		{
			if (Main.player[whoAmI].name == "poglog")
			{
				message = "poglog = nil";
				return false;
			}
			return true;
		}

		
		
	}
}
