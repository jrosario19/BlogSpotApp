using BlogApp.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        
        [ValidEmailDomain(allowedDomail: "hotmail.com", ErrorMessage = "El dominio del correo debe ser hotmail.com")]
        [Display(Name = "Correo")]
        public string Email { get; set; }
        [Required]
        [Remote(action: "IsEmailInUse", controller: "Account")]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Clave")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme Clave")]
        [Compare("Password", ErrorMessage = "Clave y Confirmación Clave no son iguales")]
        public string ConfirmPassword { get; set; }
    }
}
