using System;
using System.Collections.Generic;
using System.Text;

namespace Hambot2._1
{
    public class Auth
    {
        private const string discord_token = "MzU4NzUxMjMxMTA5MjM0Njkx.Du-T4A.YPl8pRh58huwH7yZv1IpRwK3lNI";
        private const string youtube_key = "AIzaSyBXdQH37Et__lj6dS6pfWTV9Io3lG7xpFY";

        public string GetDiscordToken()
        {
            var returnString = discord_token;

            return returnString;
        }

        public string GetYoutubeToken()
        {
            var returnString = youtube_key;

            return returnString;
        }
    }
}
