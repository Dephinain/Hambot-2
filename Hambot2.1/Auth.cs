using System;
using System.Collections.Generic;
using System.Text;

namespace Hambot2._1
{
    public class Auth
    {
        private const string discord_token = "<insert token here";
        private const string youtube_key = "<insert token here>";

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
