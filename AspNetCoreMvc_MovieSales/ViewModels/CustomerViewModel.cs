using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMvc_MovieSales.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim(Ünvan) boş geçilemez.")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Telefon boş geçilemez.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Adres boş geçilemez.")]
        public string Address { get; set; }
    }
}
