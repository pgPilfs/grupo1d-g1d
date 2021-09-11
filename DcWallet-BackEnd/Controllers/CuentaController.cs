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
    public class CuentaController : Controller
    {
        // GET: Cuenta


        public Cuenta Get(int Id1)
        {
            GestorCuenta Cuenta = new GestorCuenta();
            return Cuenta.ObtenerCuenta(Id1);
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
            Cuenta.AltaCuenta(value);
        }
  

        
        

       
        
    }
}