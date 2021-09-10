using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DC_Wallet_BackEnd.Models
{
    public class Deposito
    {
        public int idCliente;
        public int monto;
        public String tipoCuenta;
        public int idCuenta;
        public string tipoMovimientos;

        public Deposito(int idCliente, int monto, string tipoCuenta, int idCuenta,String tipoMovimientos)
        {
            IdCliente = idCliente;
            Monto = monto;
            TipoCuenta = tipoCuenta;
            IdCuenta = idCuenta;
            TipoMovimientos = tipoMovimientos;

        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int Monto { get => monto; set => monto = value; }
        public string TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string TipoMovimientos { get; internal set; }
    }
}