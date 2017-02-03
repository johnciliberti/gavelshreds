using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class Event
    {
        [Required]
        public int EventId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Title { get; set; }
        [MaxLength(1024)]
        [Required]
        public string Description { get; set; }
        public Venue Venue { get; set; }
        public IList<Media> Fliers { get; set; }
        public IList<Media> Videos { get; set; }
        public IList<Media> Photos { get; set; }
        public IList<Comment> Comments { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        
    }
}
