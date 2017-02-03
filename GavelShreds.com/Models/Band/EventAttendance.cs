using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class EventAttendance
    {
        [Required]
        public int EventAttendanceId { get; set; }
        public ApplicationUser User { get; set; }
        public EventAttendanceType Plan { get; set; }
        public bool Confirmed { get; set; }
        public Comment Comment { get; set; }
    }

    public enum EventAttendanceType { No, Maybe, Yes}
}
