using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class BandMember
    {
        [Required]
        public int BandMemberId { get; set; }

        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        [MaxLength(30)]
        public string NicName { get; set; }

        [MaxLength(100)]
        public string EmailAddress { get; set; }
        [MaxLength(100)]
        public string Twitter { get; set; }
        [MaxLength(100)]
        public string Facebook { get; set; }
        [MaxLength(100)]
        public string Instagram { get; set; }
        public List<Media> Photos { get; set; }
        public DateTime JoinedBand { get; set; }
        public DateTime LeftBand { get; set; }
        [MaxLength(10000)]
        public string Bio { get; set; }
        [MaxLength(100)]
        public string Talent { get; set; }
    }
}
