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
    public class ProfesorController : Controller
    {
        public ServiceProfesor servicio = new ServiceProfesor();

        [HttpGet]
        public ActionResult Index()
        {
            var profesor = servicio.obtenerTodos();
            return View(profesor);
        }
        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var profesor = new Profesor();
            if (id.HasValue)
                profesor = servicio.obtenerPorId(id.Value);

            ViewData["Operacion"] = operacion;
            return View(profesor);
        }
        [HttpPost]
        public ActionResult Form(Profesor profesor)
        {
            try
            {
                if (profesor.Id == 0)
                    servicio.insertar(profesor);
                else
                    servicio.modificar(profesor.Id, profesor);
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