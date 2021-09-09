using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DC_WALLET_Back.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta


        public Cuenta Get(int Id1)
        {
            GestorCuenta Cuenta = new GestorCuenta();
            return Cuenta.ObtenterCuenta(Id1);
        }


         public  GetSaldo (int idCuenta)
         {
            GestorCuenta Cuenta = new GestorCuenta();
            decimal saldo = Cuenta.ObtenerSaldo(idCuenta);

            if (saldo == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(saldo);
            }
         }

        //post cuenta

        public void Post([FromBody] Cuenta value )
        {
             GestorCuenta Cuenta = new GestorCuenta();
             Cuenta.AltaCuenta(value);
        }




        // POST: Cuenta/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuenta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cuenta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuenta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cuenta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
