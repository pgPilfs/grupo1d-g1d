using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApi.Models
{
    public class Cuenta
    {
        private int Id;
        private int IdCliente;
        private string Tipo_Cuenta;
        private double monto;
        private List<Movimiento> movimientos = new List<Movimiento>();

        public Cuenta(int idCuenta, int idCliente, double Monto, string TipoCuenta)
        {
            this.Id1 = idCuenta;
            this.IdCliente1 = idCliente;
            this.Tipo_Cuenta1 = TipoCuenta;
            this.Monto = Monto;

        }

        public int Id1 { get => Id; set => Id = value; }
        public int IdCliente1 { get => IdCliente; set => IdCliente = value; }
        public string Tipo_Cuenta1 { get => Tipo_Cuenta; set => Tipo_Cuenta = value; }
        public double Monto { get => monto; set => monto = value; }
        public List<Movimiento> Movimientos { get => movimientos; set => movimientos = value; }



        //En el modelo de la profe estaban las dos clases juntas calculo que para listas los movimientos despues (si ya la tenes sacalo)

        public class Movimiento
        {
            private int idMovimientos;
            private DateTime fechaMovimientos;
            private double monto;
            private int idCuenta;
            private string tipoCuenta;
            private string tipoMovimientos;

            public Movimiento(DateTime fechaMovimientos, double monto, int idCuenta, string tipoCuenta, String tipoMovimientos)
            {

                FechaMovimientos = fechaMovimientos;
                Monto = monto;
                IdCuenta = idCuenta;
                TipoCuenta = tipoCuenta;
                TipoMovimientos = tipoMovimientos;
            }

            public int IdMovimientos { get => idMovimientos; set => idMovimientos = value; }
            public DateTime FechaMovimientos { get => fechaMovimientos; set => fechaMovimientos = value; }
            public double Monto { get => monto; set => monto = value; }
            public int IdCuenta { get => idCuenta; set => idCuenta = value; }
            public string TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
            public string TipoMovimientos { get => tipoMovimientos; set => tipoMovimientos = value; }
        }
    }
}