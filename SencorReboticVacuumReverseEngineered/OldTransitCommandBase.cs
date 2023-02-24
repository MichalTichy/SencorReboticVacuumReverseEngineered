namespace SencorReboticVacuumReverseEngineered
{
	public abstract record OldTransitCommandBase : TransitCommandBase
	{
		public override string version => Version.Old;
	}
}