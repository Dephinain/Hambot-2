using DSharpPlus;
using DSharpPlus.CommandsNext;
using System.Threading.Tasks;
using Hambot2._1.Commands;
using Hambot2._1.YoutubeLogic;
using Microsoft.Extensions.DependencyInjection;

namespace Hambot2._1
{
    public class Program
    {
        static DiscordClient _discord;
        static CommandsNextModule _commands;
        private static void Main()
        {
           
            MainAsync().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {

            var item = new Auth();
            _discord = new DiscordClient(new DiscordConfiguration
            {
                Token = item.GetDiscordToken(),
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                LogLevel = LogLevel.Debug
            });

            _commands = _discord.UseCommandsNext(new CommandsNextConfiguration
            {
                
                StringPrefix = "~"

            });

            _commands.RegisterCommands<MainCommandController>();
            _commands.RegisterCommands<ImgurCommandController>();

            await _discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}
