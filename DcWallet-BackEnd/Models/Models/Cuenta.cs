using DcWallet_BackEnd.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;

namespace MVCWebApi.Models
{
    public class Cuenta
    {
        private int Id;
        private int IdCliente;
        private string Tipo_Cuenta;
        private string CBU;
    
        private List<Movimiento> movimientos = new List<Movimiento>();

        public Cuenta(int idCuenta, int idCliente, string CBU ,string TipoCuenta)
        {
            this.Id1 = idCuenta;
            this.IdCliente1 = idCliente;
            this.Tipo_Cuenta1 = TipoCuenta;
            this.CBU = CBU;
            

        }

        public int Id1 { get => Id; set => Id = value; }
        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public string Tipo_Cuenta1 { get => Tipo_Cuenta; set => Tipo_Cuenta = value; }

        public string CBU1 { get => CBU; set => CBU = value; }
        public List<Movimiento> Movimientos { get => movimientos; set => movimientos = value; }
        
    }
}