using System.ComponentModel.DataAnnotations;

namespace PresentationLayer.Models
{
    public class ResetPasswordModelView
    {
        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
