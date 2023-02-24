namespace SencorReboticVacuumReverseEngineered.Commands.OpCommands
{
	public abstract record OldOpCommandBase : OpCommandBase
	{
		public override string version => Version.Old;
	}
}