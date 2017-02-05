using System.ComponentModel.DataAnnotations;

namespace GavelShreds.com.Models.HomeViewModels
{
    public class ContactModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(1000,MinimumLength=5)]
        public string Message { get; set; }

        public string ContactErrorMessage { get; set; }
    }
}
