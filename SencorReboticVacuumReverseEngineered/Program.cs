using System.Net;
using System.Net.Sockets;
using System.Text;
using SencorReboticVacuumReverseEngineered.Commands;
using SencorReboticVacuumReverseEngineered.Commands.OpCommands;

namespace SencorReboticVacuumReverseEngineered
{
	internal class Program
	{
		private static readonly IPEndPoint Target = IPEndPoint.Parse("_");
		private static readonly string AuthCode = "_";
		private static readonly string TargetId = "_";
		private static readonly string TargetType = "3";

		private static async Task Main(string[] args)
		{
			await SendCommand(new CleanRooms(new CleanBlock(4, 1)));
		}

		private static async Task SendCommand(CommandBase command)
		{
			var response = await SendString(command.GetCommand, command.version);
			Console.WriteLine($"Received response: {response}");
		}

		private static async Task<string> SendString(string command, string commandVersion)
		{
			// convert the string message to bytes
			byte[] header;
			switch (commandVersion)
			{
				case Version.Old:
					header = new byte[] {0xd2, 0x00, 0x00, 0x00, 0xfa, 0x00, 0xc8, 0x00, 0x00, 0x00, 0xeb, 0x27, 0xea, 0x27, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
					break;
				case Version.New:
				default:
					header = new byte[] {0x07, 0x01, 0x00, 0x00, 0xfa, 0x00, 0xc8, 0x00, 0x00, 0x00, 0xb2, 0x27, 0b1, 0x27, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
					break;
			}

			var control = $"{{\"authCode\":\"{AuthCode}\",\"deviceIp\":\"{Target.Address}\",\"devicePort\":\"{Target.Port}\",\"targetId\":\"{TargetId}\",\"targetType\":\"{TargetType}\"}}";
			var bodyString = $"{{\"cmd\":0,\"control\":{control},\"seq\":0,\"value\":{command},\"version\":\"{commandVersion}\"}}";
			var body = Encoding.ASCII.GetBytes(bodyString);

			Console.WriteLine("Send command: " + bodyString);

			using var client = new TcpClient();
			await client.ConnectAsync(Target);
			await using var stream = client.GetStream();
			var message = header.Concat(body).ToArray();
			await stream.WriteAsync(message, 0, message.Length);
			await stream.FlushAsync();
			using StreamReader reader = new(stream, Encoding.ASCII);
			return await reader.ReadToEndAsync();
		}
	}
}