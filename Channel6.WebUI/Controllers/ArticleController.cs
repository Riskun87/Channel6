using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Channel6.Domain.Handlers;
using Channel6.WebUI.Models;
using Microsoft.Practices.ServiceLocation;

namespace Channel6.WebUI.Controllers
{
    [AllowAnonymous]
    public class ArticleController : AuthorizedController
    {
        public ArticleController(IServiceLocator serviceLocator) : base(serviceLocator)
        {
        }

        // GET: Article
        public ActionResult Index()
        {
            //return View(RSS.Read("http://www.alexandracooks.com/feed/"));

            var articles = Using<GetArticleList>()
                .Execute();

            var model = new ArticleListViewModel(articles);

            return View(model);
        }

        public ActionResult Show(int id = 1)
        {
            var article = Using<GetArticleById>().Execute(id);

            var model = new ArticleViewModel
                        {
                            Article = article
                        };

            return View(model);
        }
    }
}