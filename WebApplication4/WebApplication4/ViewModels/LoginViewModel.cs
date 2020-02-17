using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указан Логин")]
        [Display(Name = "Логин")]
        public string LoginName { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}
