using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class Comment
    {
        [Required]
        public int CommentId { get; set; }
        public ApplicationUser User { get; set; }
        public DateTime PostedDate { get; set; }
        public bool ModeratorApproved { get; set; }
        public bool Flagged { get; set; }
        public int Likes { get; set; }

    }
}
