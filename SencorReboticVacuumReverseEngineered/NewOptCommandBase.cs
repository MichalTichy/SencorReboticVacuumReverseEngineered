namespace SencorReboticVacuumReverseEngineered
{
	public abstract record NewOptCommandBase : OpCommandBase
	{
		public override string version => Version.New;
	}
}