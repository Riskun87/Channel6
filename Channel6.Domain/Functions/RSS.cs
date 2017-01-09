using System;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Channel6.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Channel6.Domain.Functions
{
    public class RSS
    {
        public static List<Article> Read(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            List<Article> articles = new List<Article>();
            foreach (SyndicationItem item in feed.Items)
            {
                Article article = new Article();
                article.Title = item.Title.Text;
                article.Summary = item.Summary.Text;
                articles.Add(article);
            }
            return articles;
        }
    }
}
