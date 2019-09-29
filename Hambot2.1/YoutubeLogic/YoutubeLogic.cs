using System;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace Hambot2._1.YoutubeLogic
{
    public class YoutubeLogic
    {
        public SearchResult YoutubeSearch(string searchTerm)
        {
            try
            {
                var auth = new Auth();
                var youtubeInfo = new YouTubeService(new BaseClientService.Initializer()
                {
                    ApiKey = auth.GetYoutubeToken(),
                    ApplicationName = this.GetType().ToString()
                });

                var searchRequest = youtubeInfo.Search.List("snippet");
                searchRequest.Q = searchTerm;
                searchRequest.MaxResults = 5;

                var searchResult = searchRequest.ExecuteAsync().Result;
                //Add in check that sees if its a channel, or better yet, hard set it to only get the first video rather than the channel.
                foreach (var item in searchResult.Items)
                {
                    switch (item.Id.Kind)
                    {
                        case "youtube#video":
                            return item;
                    }
                }
                return null;
            }
            catch ( Exception ex)
            {
                Console.Write("Error: " + ex.Message);
                return null;
            }
        }
    }
}
