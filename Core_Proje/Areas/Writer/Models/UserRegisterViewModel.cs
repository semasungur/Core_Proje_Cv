using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen kullancı soyadınızı giriniz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen resim url giriniz")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage ="Lütfen kullancı adını giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }
    }
}
