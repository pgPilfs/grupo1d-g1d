using DC_Wallet_BackEnd.Models;
using MVCWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DcWallet_BackEnd.Controllers
{
    public class ExtracciónController : ApiController
    {
        public IHttpActionResult RealizarExtraccion(Extraer operacion)
        {
            GestorExtraer gestorExtraccion = new GestorExtraer();
            GestorCuenta gestorCuenta = new GestorCuenta();
            Cuenta cuenta;
            cuenta = gestorCuenta.ObtenerCuenta(operacion.IdCuenta);

            return Ok();

        }
    }

}

