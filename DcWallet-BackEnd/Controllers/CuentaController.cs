using static MVCWebApi.Models.GestorCuenta;
using static MVCWebApi.Models.Cuenta;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCWebApi.Models;
using System.Web.Http.Cors;

namespace DC_WALLET_Back.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CuentaController : ApiController
    {
        // GET: Cuenta


        public Cuenta Get(int id)
        {
            GestorCuenta Cuenta = new GestorCuenta();
            return Cuenta.ObtenerCuenta(id);
        }

        public Cuenta Get(string cbu)
        {
            GestorCuenta cuenta_cbu = new GestorCuenta();
            return cuenta_cbu.ObtenerxCbu(cbu);
        }


        /*[System.Web.Mvc.HttpGet()]
        public IHttpActionResult GetxCBU([FromUri] string cbu)
        {
            GestorCuenta gestorCuenta = new GestorCuenta();
            var cuenta = gestorCuenta.ObtenerxCbu(cbu);
            
            if (cuenta != null) return Ok(cuenta);
            return NotFound();
        }*/


        //post cuenta

        /*public void Post([FromBody] Cuenta value)
        {
            GestorCuenta Cuenta = new GestorCuenta();
            Cuenta.AltaCuenta(value.IdCliente1, value.Tipo_Cuenta1);
        }*/

        public void Post([FromBody] Cuenta value)
        {
            GestorCuenta gCuenta = new GestorCuenta();
            gCuenta.AltaCuenta(value);
            //return value;
        }

       
    }
}