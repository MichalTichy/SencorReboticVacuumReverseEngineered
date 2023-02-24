namespace SencorReboticVacuumReverseEngineered.Commands.TransitCommands
{
	public record FindRobot : OldTransitCommandBase
	{
		public override string transitCmd => "143";
	}
}