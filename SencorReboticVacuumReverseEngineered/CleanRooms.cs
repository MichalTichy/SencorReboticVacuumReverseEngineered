namespace SencorReboticVacuumReverseEngineered
{
	public record CleanRooms : NewOptCommandBase
	{
		public CleanRooms(params CleanBlock[] blocks)
		{
			cleanBlocks = blocks;
		}

		public CleanBlock[] cleanBlocks { get; }

		public override string opCmd => "cleanBlocks";
	}
}