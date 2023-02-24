namespace SencorReboticVacuumReverseEngineered
{
	internal abstract record NewTransitCommandBase : TransitCommandBase
	{
		public override string version => Version.New;
	}
}