using System;
using System.Linq;
using Channel6.Data;
using Channel6.Domain.Models;
using Channel6.Model;

namespace Channel6.Domain.Handlers
{
    public class GetArticleById
    {
        private readonly IArticleRepository _articleRepository;

        public GetArticleById(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public virtual ArticleModel Execute(int articleId)
        {
            Article article;

            try
            {
                article = _articleRepository.GetArticle(articleId);
            }
            catch (InvalidOperationException)
            {
                return null;
            }

            return new ArticleModel(article);
        }
    }
}
