using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class Album
    {
        [Required]
        public int AlbumId { get; set; }

        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        public Media CoverArt { get; set; }
        public IList<Song> Songs { get; set; }
    }
}
