using Google.Apis.YouTube.v3.Data;

namespace Hambot2._1.YoutubeLogic
{
    public interface IYoutubeLogic
    {
        SearchResult YoutubeSearch(string searchTerm);
    }
}