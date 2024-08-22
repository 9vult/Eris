using Discord;
using Discord.WebSocket;
using dotenv.net;
using Eris.Listeners;

namespace Eris
{
    public class Eris
    {
        private static readonly DiscordSocketClient _client = new();

        public static DiscordSocketClient Client => _client;

        public static async Task Main()
        {
            try
            {
                // Get bot token
                var environment = DotEnv.Read();
                environment.TryGetValue("TOKEN", out string? token);

                // Set up client
                _client.Log += Log;

                _client.Ready += Listener.Ready;
                _client.SlashCommandExecuted += Listener.SlashCommandExecuted;

                await _client.LoginAsync(TokenType.Bot, token);
                await _client.StartAsync();

                // Block this task until the program exits
                await Task.Delay(-1);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                Environment.Exit(1);
            }
        }

        private static Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}