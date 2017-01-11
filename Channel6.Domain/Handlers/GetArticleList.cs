using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Channel6.Data;
using Channel6.Domain.Models;
using Channel6.Model;

namespace Channel6.Domain.Handlers
{
    public class GetArticleList
    {
        private readonly IArticleRepository _articleRepository;

        public GetArticleList(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public virtual IEnumerable<ArticleModel> Execute()
        {
            IEnumerable<Article> articleData = null;

            try
            {
                articleData = _articleRepository.GetArticles();
            }
            catch (InvalidOperationException e)
            {
                return null;
            }

            var articles = from article in articleData
                           orderby article.ArticleId
                           select new ArticleModel(article);

            return articles;

        }
    }
}
