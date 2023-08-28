using System.ComponentModel.DataAnnotations;

namespace OtomasyonProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "İsim boş geçilemez!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim boş geçilemez!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email boş geçilemez!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar boş geçilemez!")]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
