namespace SencorReboticVacuumReverseEngineered
{
	public abstract record OldOpCommandBase : OpCommandBase
	{
		public override string version => Version.Old;
	}
}