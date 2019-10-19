using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DontPanic.TumblrSharp;
using DontPanic.TumblrSharp.Client;
using DontPanic.TumblrSharp.OAuth;

namespace Hambot2._1.TumblrLogic
{
    public class TargetComboLogic
    {
       public string SendTargetComboStrip()
        {
            try
            {
                var auth = new Auth();
                var info = auth.GetTumblrConsumerInfo();
                TumblrClient client = new TumblrClientFactory().Create<TumblrClient>(info.ConsumerKey,
                    info.ConsumerSecret, new Token(info.TumblrToken, info.TokenSecret));

                var posts = GetTargetComboStrip(client);
                var post = posts.Result.Result.ElementAtOrDefault(new Random().Next(0, posts.Result.Result.Count()));
                var photo = (PhotoPost)post;
               var url = photo.Photo.OriginalSize.ImageUrl;


               return url;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

       public async Task<Posts> GetTargetComboStrip(TumblrClient client)
       {
           return await client.GetPostsAsync("targetcombo", 0L, 20, PostType.Photo);
       }
    }
}
