using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Channel6.Domain.Entities
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Source { get; set; }
        public string Language { get; set; }
        public DateTime DateTimeAdded { get; set; }
        public ArticleStatus Status { get; set; }
        public ArticleType Type { get; set; }
        public string Summary { get; set; }
    }

    public enum ArticleStatus
    {

    }

    public enum ArticleType
    {

    }
}
