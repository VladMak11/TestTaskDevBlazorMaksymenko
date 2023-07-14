using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorAppModels.ModelHelper;

namespace BlazorAppModels.ViewModel
{
    public class UserVM
    {
        [Required]
        public string Id { get; set; }
        [Required(ErrorMessage = "The name field is required.")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }

        [Required(ErrorMessage = "The phone number field is required.")]
        [Display(Name = "Phone number"), MaxLength(13)]
        [RegularExpression(@"^\+380\d{9}$", ErrorMessage = "Invalid phone number format. The phone number must be in the format +380XXXXXXXXX.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "The sum field is required.")]
        public decimal InitialPropertyValueSum { get; set; }
        [Required(ErrorMessage = "The sum field is required.")]
        public decimal CurrentPropertyValueSum { get; set; }
    }
}
