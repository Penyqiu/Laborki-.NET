using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZAD6.Models;

namespace ZAD6.Controller
{
    public class SiteController
    {
        public ActionResult Index()
        {
            // Read the list  
            var blogs = PostModel.Read();
            if (blogs == null)
            {
                ViewBag.Empty = true;
                return View();
            }
            else
            {
                // Just for sorting.  
                blogs = (from blog in blogs
                         orderby blog.CreateTime descending
                         select blog).ToList();

                ViewBag.Empty = false;
                return View(blogs);
            }
        }
    }
}