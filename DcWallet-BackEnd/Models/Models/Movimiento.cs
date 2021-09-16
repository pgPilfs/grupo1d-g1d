using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DcWallet_BackEnd.Models.Models
{


    //En el modelo de la profe estaban las dos clases juntas calculo que para listas los movimientos despues (si ya la tenes sacalo)

    public class Movimiento
    {
        private int idMovimientos;
        private DateTime fechaMovimientos;
        private double monto;
        private int idCuenta;
        private int cuentaExternaId;
        private string tipoMovimientos;

        public Movimiento(DateTime fechaMovimientos, double monto, int idCuenta, int cuentaExternaId, String tipoMovimientos)
        {

            FechaMovimientos = fechaMovimientos;
            Monto = monto;
            IdCuenta = idCuenta;
            CuentaExternaId = cuentaExternaId;
            TipoMovimientos = tipoMovimientos;
        }

        public int IdMovimientos { get => idMovimientos; set => idMovimientos = value; }
        public DateTime FechaMovimientos { get => fechaMovimientos; set => fechaMovimientos = value; }
        public double Monto { get => monto; set => monto = value; }
        public int IdCuenta { get => idCuenta; set => idCuenta = value; }
        public int CuentaExternaId { get => cuentaExternaId; set => cuentaExternaId = value; }
        public string TipoMovimientos { get => tipoMovimientos; set => tipoMovimientos = value; }
    }
}