using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RedditAPI.Models
{
    public class RedditPost
    {
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string LinkURL { get; set; }
        //So we wana put parsing code in here to help make the code more portable

        public RedditPost()
        {

        }

        public RedditPost(string APIText, int i)
        {
            JObject redditJson = JObject.Parse(APIText);

            List<JToken> posts = redditJson["data"]["children"].ToList();

            JToken post = posts[i];

            Title = post["data"]["title"].ToString();
        }
    }
}