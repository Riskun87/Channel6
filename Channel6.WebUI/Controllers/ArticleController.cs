using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Channel6.Domain.Functions;

namespace Channel6.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View(RSS.Read("http://www.alexandracooks.com/feed/"));
        }
    }
}