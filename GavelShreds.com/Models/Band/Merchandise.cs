using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GavelShreds.com.Models.Band
{
    public class Merchandise
    {
        [Required]
        public int MerchandiseId { get; set; }
        [Required]
        [MaxLength]
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public float Price { get; set; }
        public bool InStock { get; set; }
        public IList<Media> Photos { get; set; }
    }

    public enum MerchandiseType { CD, TShirt, Sticker, Pin, Hat}
}
