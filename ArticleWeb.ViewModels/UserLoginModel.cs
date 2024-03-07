using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleWeb.ViewModels
{
    public class UserLoginModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is a required field.")]
        public string UserName { get; set; } = string.Empty;

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is a required field.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters.")]
        public string Password { get; set; } = string.Empty;
    }
}
