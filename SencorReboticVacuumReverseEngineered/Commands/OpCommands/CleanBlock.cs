namespace SencorReboticVacuumReverseEngineered.Commands.OpCommands
{
	public record CleanBlock
	{
		public CleanBlock(int blockNum, int cleanNum)
		{
			this.cleanNum = cleanNum.ToString();
			this.blockNum = blockNum.ToString();
		}

		public string cleanNum { get; init; }
		public string blockNum { get; init; }
	}
}