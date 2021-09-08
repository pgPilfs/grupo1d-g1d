using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DC_Wallet_BackEnd.Models
{
    public class Transferencia
    {
        private int idCuenta;
        private int monto;

        public Transferencia(int idCuenta, int monto)
        {
            IdCuenta = idCuenta;
            Monto = monto;
        }

        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public int Monto { get => monto; set => monto = value; }
        public string TipoMovimientos { get; internal set; }
    }
}