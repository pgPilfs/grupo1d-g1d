using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DC_Wallet_BackEnd.Models
{
    public class Extraer
    {
        public  string IdTipoMovimientos;//nombramos las variables
        public int Monto;
        public DateTime FechaMovimientos;
        public int IdCuenta;
        public string TipoMovimientos;


        public Extraer(string idTipoMovimientos1, int monto1, DateTime fechaMovimientos1, int idCuenta1)//el constructor va asignar usando las propiedades pero termina asignando las variables
        {
            IdTipoMovimientos1 = idTipoMovimientos1;
            Monto1 = monto1;
            FechaMovimientos1 = fechaMovimientos1;
            IdCuenta1 = idCuenta1;
        }

        public string IdTipoMovimientos1 { get => IdTipoMovimientos; set => IdTipoMovimientos = value; }//creamos las propiedades que vamos a setear en la base
        public int Monto1 { get => Monto; set => Monto = value; }
        public DateTime FechaMovimientos1 { get => FechaMovimientos; set => FechaMovimientos = value; }
        public int IdCuenta1 { get => IdCuenta; set => IdCuenta = value; }
        public string NombreOperacion { get; internal set; }
    }
}