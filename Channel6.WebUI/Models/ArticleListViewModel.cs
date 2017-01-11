using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Channel6.Domain.Models;

namespace Channel6.WebUI.Models
{
    public class ArticleListViewModel
    {
        public IEnumerable<ArticleModel> Articles { get; private set; }

        public ArticleListViewModel(IEnumerable<ArticleModel> articles)
        {
            Articles = articles;
        }
    }
}