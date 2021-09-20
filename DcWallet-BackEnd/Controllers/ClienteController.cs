using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCWebApi.Models;
using System.Web.Http.Cors;

namespace MVCWebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClienteController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Cliente> Get()  // YA ANDA
        {
            GestorCliente gCliente = new GestorCliente();
            return gCliente.ObtenerClientes();
        }

        // GET api/<controller>/5
        public Cliente Get(int id) //YA ANDA
        {
            GestorCliente gestorCliente = new GestorCliente();
            return gestorCliente.ObtenerCliente(id);
        }

        // POST api/<controller> //YA ANDA 
        public Cliente Post([FromBody] Cliente value)
        {
            GestorCliente gCliente = new GestorCliente();
            value.IdCliente = gCliente.Registrar(value);
            return value;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public Cliente Delete(int idCliente)
        {
            GestorCliente gCliente = new GestorCliente();
            gCliente.Eliminar(idCliente);
            return null;
            
        }
    }
}