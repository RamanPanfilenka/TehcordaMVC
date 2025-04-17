using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Tehcorda.MVC.Models
{
    public class LoginModel
    {
        [Required]
        [MinLength(4, ErrorMessage = "You must give me at least 4 symbols.")]
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [BindNever]
        public bool IsAdmin { get; set; }
    }
}
