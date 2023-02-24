namespace SencorReboticVacuumReverseEngineered.Commands.OpCommands
{
	public abstract record OpCommandBase : CommandBase
	{
		public abstract string opCmd { get; }
	}
}