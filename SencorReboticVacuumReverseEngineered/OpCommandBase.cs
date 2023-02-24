namespace SencorReboticVacuumReverseEngineered
{
	public abstract record OpCommandBase : CommandBase
	{
		public abstract string opCmd { get; }
	}
}