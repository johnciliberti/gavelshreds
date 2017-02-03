using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class Media
    {
        [Required]
        public int MediaId { get; set; }
        public double Accesses { get; set; }
        public MediaType MediaType { get; set; }
        public MediaSource MediaSource { get; set; }
        [Required]
        [MaxLength(1024)]
        public string Location { get; set; }
        public double SizeInBytes { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public double Likes { get; set; }


    }

    public enum MediaType
    {
        Photo,
        Music,
        Video
    }

    public enum MediaSource
    {
        Disk,
        Azure,
        YouTube,
        SoundCloud
    }
}
