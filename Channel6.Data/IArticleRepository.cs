using System.Collections.Generic;
using Channel6.Model;

namespace Channel6.Data
{
    public interface IArticleRepository
    {
        void Create(Article article);
        Article GetArticle(int articleId);
        IEnumerable<Article> GetArticles();
        void Update(Article article);
        void Delete(int articleId);
    }
}
