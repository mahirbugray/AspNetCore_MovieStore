using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMvc_MovieSales.ViewModels
{
    public class CustomerLoginViewModel
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage = "Hatalı email girişi!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }
    }
}
