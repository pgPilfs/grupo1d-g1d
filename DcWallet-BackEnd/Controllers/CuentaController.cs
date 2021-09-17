using static MVCWebApi.Models.GestorCuenta;
using static MVCWebApi.Models.Cuenta;
using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Configuration;
using System.Web.Http;

namespace DC_WALLET_Back.Controllers
{
    public class CuentaController : ApiController
    {
        // GET: Cuenta


        public Cuenta Get(int id)
        {
            GestorCuenta Cuenta = new GestorCuenta();
            return Cuenta.ObtenerCuenta(id);
        }

        [System.Web.Mvc.HttpGet()]
        public IHttpActionResult GetxCBU([FromUri] string cbu)
        {
            GestorCuenta gestorCuenta = new GestorCuenta();
            var cuenta = gestorCuenta.ObtenerxCbu(cbu);
            if (cuenta != null) return Ok(cuenta);
            return NotFound();
        }


        /*public Cuenta Get(int idCuenta)
        {
            GestorCuenta cuenta = new GestorCuenta();
            decimal saldo =  cuenta.ObtenerSaldo(idCuenta);

            if (saldo == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(saldo);
            }

        }*/

        //post cuenta

        public void Post([FromBody] Cuenta value)
        {
            GestorCuenta Cuenta = new GestorCuenta();
            Cuenta.AltaCuenta(value.IdCliente1, value.Tipo_Cuenta1);
        }
        






    }
}