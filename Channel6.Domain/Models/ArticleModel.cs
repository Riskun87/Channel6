using System;
using Channel6.Model;

namespace Channel6.Domain.Models
{
    public class ArticleModel
    {
        private Model.Article Article { get; set; }

        public ArticleModel(Article article)
        {
            Article = article;
        }

        public int ArticleId { get { return this.Article.ArticleId; } }

        public string Title
        {
            get { return this.Article.Title; }
        }

        public string Summary
        {
            get { return this.Article.Summary; }
        }

        public string Text
        {
            get { return this.Article.Text; }
        }

        public string Source
        {
            get { return this.Article.Source; }
        }

        public string Language
        {
            get { return this.Article.Language; }
        }

        public DateTime DateTimeAdded
        {
            get { return this.Article.DateTimeAdded; }
        }

        public DateTime DateTimeModified
        {
            get { return this.Article.DateTimeModified; }
        }

        public ArticleStatus Status
        {
            get { return this.Article.Status; }
        }

        public ArticleType Type
        {
            get { return this.Article.Type; }
        }
    }
}
