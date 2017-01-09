using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Channel6.Domain.Entities
{
    public class Channel
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Website")]
        public string Website { get; set; }
        [Required]
        [Display(Name = "Resource")]
        public string Resource { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Type")]
        public ChannelType Type { get; set; }
    }

    public enum ChannelType
    {
        RSS = 1,
        Youtube = 2
    }
}
