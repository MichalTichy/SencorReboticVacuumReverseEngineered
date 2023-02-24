namespace SencorReboticVacuumReverseEngineered.Commands.TransitCommands
{
	public record StartCleaning : OldTransitCommandBase
	{
		public override string transitCmd => "100";
	}
}