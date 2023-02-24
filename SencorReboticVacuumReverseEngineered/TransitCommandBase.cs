namespace SencorReboticVacuumReverseEngineered
{
	public abstract record TransitCommandBase : CommandBase
	{
		public abstract string transitCmd { get; }
	}
}