using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.wepApi.ViewModels
{
    public class LoginViewModels
    {

        [Required(ErrorMessage = "Informe o e-mnail do usuario!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o e-mnail do usuario!")]
        public string Senha  { get; set; }
    }
}
