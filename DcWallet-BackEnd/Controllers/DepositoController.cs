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

    [Route("deposito")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DepositoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult RealizarDeposito(Deposito operacion)
        {
            GestorDeposito gestorDepositar = new GestorDeposito();

            if (operacion.monto > 0)
            {
                gestorDepositar.OperacionDeposito(operacion);
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }



    }

}
