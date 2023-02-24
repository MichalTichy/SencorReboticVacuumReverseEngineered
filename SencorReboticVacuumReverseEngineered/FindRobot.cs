namespace SencorReboticVacuumReverseEngineered
{
	public record FindRobot : OldTransitCommandBase
	{
		public override string transitCmd => "143";
	}
}