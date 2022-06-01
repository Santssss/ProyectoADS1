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
    public class MateriaController : Controller
    {
        public ServiceMateria servicio = new ServiceMateria();

        [HttpGet]
        public ActionResult Index()
        {
            var materia = servicio.obtenerTodos();
            return View(materia);
        }
        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var materia = new Materia();
            if (id.HasValue)
                materia = servicio.obtenerPorId(id.Value);

            ViewData["Operacion"] = operacion;
            return View(materia);
        }
        [HttpPost]
        public ActionResult Form(Materia materia)
        {
            try
            {
                if (materia.Id == 0)
                    servicio.insertar(materia);
                else
                    servicio.modificar(materia.Id, materia);
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