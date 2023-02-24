using SencorReboticVacuumReverseEngineered.Commands.OpCommands;

namespace SencorReboticVacuumReverseEngineered.Commands.TransitCommands
{
	public abstract record NewOptCommandBase : OpCommandBase
	{
		public override string version => Version.New;
	}
}