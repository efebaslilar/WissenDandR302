using System.ComponentModel.DataAnnotations;

namespace WissenDandR302PresentationLayer.Models
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
