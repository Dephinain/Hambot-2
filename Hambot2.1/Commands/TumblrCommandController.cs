using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using Hambot2._1.TumblrLogic;

namespace Hambot2._1.Commands
{
    public class TumblrCommandController
    {
        public readonly TargetComboLogic _targetComboLogic;
        public TumblrCommandController()
        {
            _targetComboLogic = new TargetComboLogic();
        }

        [Command("targetcombo")]
        public async Task TargetCombo(CommandContext context)
        {
           await context.TriggerTypingAsync();
           var comic = _targetComboLogic.SendTargetComboStrip();
           await context.RespondAsync(embed: comic);
        }
    }
}
