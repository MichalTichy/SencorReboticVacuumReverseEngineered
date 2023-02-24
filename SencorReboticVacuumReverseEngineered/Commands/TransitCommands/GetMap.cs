namespace SencorReboticVacuumReverseEngineered.Commands.TransitCommands
{
	internal record GetMap : NewTransitCommandBase
	{
		public override string transitCmd => "133";
		public string mapHeight => "0";
		public string mapWidth => "0";
		public string mapSign => "MA==";
		public string trackNum => "MA==";
	}
}