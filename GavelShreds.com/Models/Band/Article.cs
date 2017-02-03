using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class Article
    {
        [Required]
        public int ArticleId { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(1024)]
        public string Summary { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime ArchiveDate { get; set; }
        public bool Publish { get; set; }
        public IList<Media> Media { get; set; }
        public double Accesses { get; set; }
        public IList<Comment> Comments {get;set;}
    }
}
