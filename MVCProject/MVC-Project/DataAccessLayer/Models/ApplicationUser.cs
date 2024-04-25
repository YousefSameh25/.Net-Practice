using Microsoft.AspNetCore.Identity;

namespace PresentationLayer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public bool IsAgree { get; set; }
    }
}
