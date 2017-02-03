using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class Venue
    {
        [Required]
        public int VenueId { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        [Required]
        public string Address1 { get; set; }
        [MaxLength(100)]
        public string Address2 { get; set; }
        [MaxLength(100)]
        [Required]
        public string City { get; set; }
        [MaxLength(10)]
        [Required]
        public string State { get; set; }
        [MaxLength(10)]
        [Required]
        public string ZipCode { get; set; }
        public float Longitude { get; set; }
        public float Lattitude { get; set; }
        public List<Media> Photos { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
}
