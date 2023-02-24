namespace SencorReboticVacuumReverseEngineered.Commands.TransitCommands
{
    public abstract record TransitCommandBase : CommandBase
    {
        public abstract string transitCmd { get; }
    }
}