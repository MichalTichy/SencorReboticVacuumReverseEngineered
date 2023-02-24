namespace SencorReboticVacuumReverseEngineered.Commands.TransitCommands
{
	public record GoCharging : OldTransitCommandBase
	{
		public string charge => "1";
		public override string transitCmd => "104";
	}
}