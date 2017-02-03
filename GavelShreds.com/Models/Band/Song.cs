using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class Song
    {
        [Required]
        public int SongId { get; set; }
        public Media Audio { get; set; }
        public Media Video { get; set; }
        public Media Photo { get; set; }
        [MaxLength(5000)]
        public string Lyrics { get; set; }
        [MaxLength(5000)]
        public string BackStory { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
