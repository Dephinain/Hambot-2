using System;
using System.Collections.Generic;
using System.Text;

namespace Hambot2._1
{
    public class Auth
    {
        private const string discord_token = "nah";
        private const string youtube_key = "nope";

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
