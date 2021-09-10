using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DC_WALLET_Back.Models
{
    public class Cliente
    {
        private int idCliente; //se crean las propiedas//
        private int dni;
        private int cP;
        private String nombre;
        private String apellido;
        private String ciudad;
        private String provincia;
        private String nombreUsuario;
        private String email;
        private byte[] fotoDni;

        public Cliente(int idCliente, int dni, int cP, string nombre, string apellido, string ciudad, string provincia, string nombreUsuario, string email, byte[] fotoDni)
        {
            IdCliente = idCliente;
            Dni = dni;
            CP = cP;
            Nombre = nombre;
            Apellido = apellido;
            Ciudad = ciudad;
            Provincia = provincia;
            NombreUsuario = nombreUsuario;
            Email = email;
            FotoDni = fotoDni; //el contructor asigna el valor a las variables respetando las propiedas//
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }//se crean las propiedades que se le van a pasar a la base de datos-- con la creación de la instacia ya le podemos asignar valores a la base//
        public int Dni { get => dni; set => dni = value; }
        public int CP { get => cP; set => cP = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Email { get => email; set => email = value; }
        public byte[] FotoDni { get => fotoDni; set => fotoDni = value; }
    }
}