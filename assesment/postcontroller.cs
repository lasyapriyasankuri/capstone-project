using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comments_challenge.Controllers
{
    public class PostsController : Controller
    {
        private readonly CommentDAL _comment;

        public PostsController(CommentDAL comment)
        {
            _comment = comment;
        }

        [HttpGet]
        public ActionResult Index(string title, string sortOrder)
        {
            var postList = _comment.GetPosts();
            return View(postList);
        }
    }
}
