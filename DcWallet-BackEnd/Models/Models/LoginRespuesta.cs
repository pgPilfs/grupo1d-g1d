using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace MVCWebApi.Models
{
    public class LoginRespuesta
    {
        //esta fue la solucion que me daba visual vamos a ver si funciona
        public LoginRespuesta(string token, int idCliente, string nombre, string nombreUsuario)
        {
            Token = token;
            this.idCliente = idCliente;
            Nombre = nombre;
            NombreUsuario = nombreUsuario;
        }

        public LoginRespuesta(string token, int id, string nombre, string apellido, string nombreUsuario)
        {
            Token = token;
            idCliente = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
        }


        public string Token { get; set; }
        public int idCliente { get; set; }
        public string Nombre { get;  set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
    }
}