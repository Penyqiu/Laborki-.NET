using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using Newtonsoft.Json;

namespace ZAD6.Models
{
    public class PostModel
    {
        
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }

         
        public DateTime CreateTime { get; set; }

          

        private static string PostsFile = HttpContext.Current.Server.MapPath("~/App_Data/Posts.json");

        private static List<PostModel> posts = new List<PostModel>();
        public static List<PostModel> Read()
        {
            // Check if the file exists.  
            if (!File.Exists(PostsFile))
            {
                File.Create(PostsFile).Close();
                File.WriteAllText(PostsFile, "[]"); 
            }
            posts = JsonConvert.DeserializeObject<List<PostModel>>(File.ReadAllText(PostsFile));
            return posts;
        }

    }
}
