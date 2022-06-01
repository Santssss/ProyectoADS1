using CRUD_Memoria.Models;
using CRUD_Memoria.Services;
using CRUD_Memoria.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Memoria.Controllers
{
    public class CarreraController : Controller
    {
        public ServiceCarrera servicio = new ServiceCarrera();

        [HttpGet]
        public ActionResult Index()
        {
            var carrera = servicio.obtenerTodos();
            return View(carrera);
        }
        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var carrera = new Carrera();
            if (id.HasValue)
                carrera = servicio.obtenerPorId(id.Value);

            ViewData["Operacion"] = operacion;
            return View(carrera);
        }
        [HttpPost]
        public ActionResult Form(Carrera carrera)
        {
            try
            {
                if (carrera.Id == 0)
                    servicio.insertar(carrera);
                else
                    servicio.modificar(carrera.Id, carrera);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                servicio.eliminar(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}