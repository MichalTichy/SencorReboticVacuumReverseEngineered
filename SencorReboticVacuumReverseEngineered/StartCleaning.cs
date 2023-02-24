namespace SencorReboticVacuumReverseEngineered
{
	public record StartCleaning : OldTransitCommandBase
	{
		public override string transitCmd => "100";
	}
}