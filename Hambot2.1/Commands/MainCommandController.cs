using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace Hambot2._1.Commands
{
    public class MainCommandController
    {
        public readonly YoutubeLogic.YoutubeLogic _youtubeLogic;

        public MainCommandController()
        {
            _youtubeLogic = new YoutubeLogic.YoutubeLogic();
        }

        [Command("yello")]
        public async Task Yello(CommandContext context)
        {
            await context.TriggerTypingAsync();
            await context.RespondAsync($"HEY {context.User.Mention}, YOU BITCH");
        }

        [Command("yt")]
        public async Task YoutubeSearch(CommandContext context, string searchTerm)
        {
            await context.TriggerTypingAsync();
            var test = _youtubeLogic.YoutubeSearch(context.RawArgumentString);
            await context.RespondAsync($"https://www.youtube.com/watch?v=" + test.Id.VideoId);
        }

        [Command("cmds")]
        public async Task Command(CommandContext context)
        {
            await context.TriggerTypingAsync();
            await context.RespondAsync(@"```All commands are prefixed by the '~' character.
List of current commands: yello: The bot responds to your inquiry as it is programmed to do so.
                          yt: Searches youtube for the first video that best matches your search term. Ex '~yt under pressure'
                          cmds: Tells you what commands there are for the bot. Like so!
                          :mystery: : It is a mystery.```");
        }

        [Command("<:mystery:532081139419185153>")]
        public async Task Mystery(CommandContext context)
        {
            await context.TriggerTypingAsync();
            await context.RespondAsync("https://www.youtube.com/watch?v=fq3abPnEEGE");
        }

    }
}
