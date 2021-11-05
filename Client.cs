using Terraria.ModLoader.Config;

namespace tstands
{
	public class Client : ModConfig
	{
		[Label("Show Test UI")]
		public bool testui;

		[Label("Show mod origin in tooltip")]
		public bool ShowModOriginTooltip;

		public override ConfigScope Mode => (ConfigScope)1;

		public override void OnChanged()
		{
		
		}

		
	}
}
