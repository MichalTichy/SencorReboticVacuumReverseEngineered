using Newtonsoft.Json;

namespace SencorReboticVacuumReverseEngineered.Commands
{
	public abstract record CommandBase
	{
		[JsonIgnore]
		public abstract string version { get; }

		[JsonIgnore]
		public string GetCommand => JsonConvert.SerializeObject(this);
	}
}