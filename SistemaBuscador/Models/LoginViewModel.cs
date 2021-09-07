using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBuscador.Models
{
    public class LoginViewModel
    {
        public string Ususario { get; set; }
        [Display(Name = "Contraseña")]

        public string Password { get; set; }
       
    }
}
