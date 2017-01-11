using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Channel6.Model;

namespace Channel6.Data.SqlCe.Repositories
{
    public class ArticleRepository : BaseRepository, IArticleRepository
    {
        public ArticleRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void Create(Article article)
        {
            this.GetDbSet<Article>().Add(article);
            this.UnitOfWork.SaveChanges();
        }

        public Article GetArticle(int articleId)
        {
            return this.GetDbSet<Article>()
                .Where(a => a.ArticleId == articleId)
                .Single();
        }

        public IEnumerable<Article> GetArticles()
        {
            return this.GetDbSet<Article>()
                .ToList();
        }

        public void Update(Article updatedArticle)
        {
            Article articleToUpdate =
                this.GetDbSet<Article>()
                        .Where(a => a.ArticleId == updatedArticle.ArticleId)
                        .First();

            articleToUpdate.Title = updatedArticle.Title;
            articleToUpdate.Summary = updatedArticle.Summary;
            articleToUpdate.Source = updatedArticle.Source;
            articleToUpdate.Language = updatedArticle.Language;
            articleToUpdate.DateTimeAdded = updatedArticle.DateTimeAdded;
            articleToUpdate.DateTimeModified = updatedArticle.DateTimeModified;
            articleToUpdate.Status = updatedArticle.Status;
            articleToUpdate.Type = updatedArticle.Type;

            this.SetEntityState(articleToUpdate, articleToUpdate.ArticleId == 0
                                                    ? EntityState.Added
                                                    : EntityState.Modified);
            this.UnitOfWork.SaveChanges();
    }

        public void Delete(int articleId)
        {
            Article article =
                this.GetDbSet<Article>()
                    .Where(a => a.ArticleId == articleId)
                    .Single();

            this.GetDbSet<Article>().Remove(article);

            this.UnitOfWork.SaveChanges();
        }
    }
}
