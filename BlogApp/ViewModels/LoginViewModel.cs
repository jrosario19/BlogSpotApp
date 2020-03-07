using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public String UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Clave")]
        public string Password { get; set; }
        [Display(Name = "Recordar Usuario")]
        public bool Rememberme { get; set; }
    }
}
