using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Configuration = AngleSharp.Configuration;
using AngleSharp;
using AngleSharp.Html.Dom;


namespace Hambot2._1.Commands
{
    public class ImgurCommandController
    {
        [Command("fuckyou")]
        public async Task Yello(CommandContext context)
        {
            await context.TriggerTypingAsync();
            await context.RespondAsync($"I'M THE BOSS OF THIS GYM, ASSHOLE");
            await context.RespondAsync("https://i.imgur.com/zHnmkmB.jpg");
        }

        [Command("rimg")]
        public async Task RandomImage(CommandContext context)
        {
            if (string.IsNullOrEmpty(context.RawArgumentString))
            {
                await context.TriggerTypingAsync();
                await context.RespondAsync("I need a query passed in after 'rimg' to work properly, stupid.");
                return;
            }

            var terms = context.RawArgumentString.Trim();
            var query = WebUtility.UrlEncode(terms).Replace(' ', '+');
            try
            {
                var queryLink = $"http://imgur.com/search?q={ query }";
                var config = Configuration.Default.WithDefaultLoader();

                using (var document = await BrowsingContext.New(config).OpenAsync(queryLink).ConfigureAwait(false))
                {
                    var items = document.QuerySelectorAll("a.image-list-link").ToList();

                    if (!items.Any())
                        return;
                    var image = (items.ElementAtOrDefault(new Random().Next(0, items.Count)) as IHtmlAnchorElement);

                    if (image?.Href == null)
                        return;
                    await context.RespondAsync(image.Href);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        [Command("meow")]
        public async Task RandomCat(CommandContext context)
        {
            var queryLink = "https://imgur.com/search/score/all?q_exactly=kitten%20cat&q_all=";
            var config = Configuration.Default.WithDefaultLoader();
            using (var document = await BrowsingContext.New(config).OpenAsync(queryLink).ConfigureAwait(false))
            {
                var items = document.QuerySelectorAll("a.image-list-link").ToList();
            }
        }

    }
}
