using System;
using System.ComponentModel.DataAnnotations;

namespace Channel6.Model
{
    public class Article
    {
        [Required]
        public int ArticleId { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(1024)]
        public string Summary { get; set; }
        public string Text { get; set; }
        [StringLength(2048)]
        public string Source { get; set; }
        [StringLength(2)]
        public string Language { get; set; }
        public DateTime DateTimeAdded { get; set; }
        public DateTime DateTimeModified { get; set; }
        public ArticleStatus Status { get; set; }
        public ArticleType Type { get; set; }
        
    }

    public enum ArticleStatus
    {

    }

    public enum ArticleType
    {

    }
}
