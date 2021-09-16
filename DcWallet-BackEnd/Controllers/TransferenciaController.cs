using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using DC_Wallet_BackEnd.Models;
using MVCWebApi.Models;

namespace DcWallet_BackEnd.Controllers
{
    public class TransferenciaController : ApiController
    {
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public IHttpActionResult RealizarTransferencia(Transferencia operacion)
        {
            var gTransferir = new GestorTransferencia();
            var gestorCuenta = new GestorCuenta();
            Cuenta cuentaDesde;
            //Cuenta cuentaHasta;
            cuentaDesde = gestorCuenta.ObtenerCuenta(operacion.IdCuenta);
            //cuentaHasta = gestorCuenta.ObtenerCuentaPorCvu(operacion.cvuHasta);
            if (operacion.Monto > 0)
            {
                gTransferir.OperacionTransferir(operacion);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }


    }
}

