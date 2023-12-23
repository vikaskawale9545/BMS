using System.ComponentModel.DataAnnotations;

namespace BMS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}