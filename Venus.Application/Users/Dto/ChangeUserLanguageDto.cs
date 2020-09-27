using System.ComponentModel.DataAnnotations;

namespace Venus.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}