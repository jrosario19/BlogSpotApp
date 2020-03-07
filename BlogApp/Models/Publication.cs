using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Models
{
    public class Publication
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Titulo")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Contenido")]
        public string Content { get; set; }
        [Required]
        [Display(Name = "Fecha de Creación")]
        public DateTime DateTime { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
