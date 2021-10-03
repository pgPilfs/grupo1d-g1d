using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DcWallet_BackEnd.Models.Models
{
    public class Login
    {
        private string nombreUsuario;
        private int password;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public int Password { get => password; set => password = value; }
    }
}