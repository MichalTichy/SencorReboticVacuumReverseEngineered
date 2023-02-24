using SencorReboticVacuumReverseEngineered.Commands.TransitCommands;

namespace SencorReboticVacuumReverseEngineered.Commands.OpCommands
{
	public record CleanRooms : NewOptCommandBase
	{
		public CleanBlock[] cleanBlocks { get; }

		public override string opCmd => "cleanBlocks";

		public CleanRooms(params CleanBlock[] blocks)
		{
			cleanBlocks = blocks;
		}
	}
}