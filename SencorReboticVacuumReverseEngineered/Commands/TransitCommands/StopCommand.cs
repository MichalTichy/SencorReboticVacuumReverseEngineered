namespace SencorReboticVacuumReverseEngineered.Commands.TransitCommands
{
	internal record StopCommand : NewTransitCommandBase
	{
		public string stop => "1";
		public string isStop => "1";
		public override string transitCmd => "102";
	}
}