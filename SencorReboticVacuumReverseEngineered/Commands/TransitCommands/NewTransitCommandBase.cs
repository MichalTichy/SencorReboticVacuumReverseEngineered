namespace SencorReboticVacuumReverseEngineered.Commands.TransitCommands
{
	internal abstract record NewTransitCommandBase : TransitCommandBase
	{
		public override string version => Version.New;
	}
}