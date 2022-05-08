using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ZAD6.Models
{
    // The class to manage the data-sources  
    public class PostManager
    {
        // Define the members  
        private static string PostsFile = HttpContext.Current.Server.MapPath("~/App_Data/Posts.json");
        private static List<PostModel> posts = new List<PostModel>();

        // The CRUD functions  
        public static void Create(string postJson)
        {
            var obj = JsonConvert.DeserializeObject<PostModel>(postJson);

            if (posts.Count > 0)
            {
                posts = (from post in posts
                         orderby post.CreateTime
                         select post).ToList();
                obj.ID = posts.Last().ID + 1;
            }
            else
            {
                obj.ID = 1;
            }

            posts.Add(obj);
            save();
        }


        public static void Update(int id, string postJson)
        {
            Delete(id);
            Create(postJson);
            save();
        }

        public static void Delete(int id)
        {
            posts.Remove(posts.Find(x => x.ID == id));
            save();
        }

       
        private static void save()
        {
            File.WriteAllText(PostsFile, JsonConvert.SerializeObject(posts));
        }

    }
}     
