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
    public class EstudianteController : Controller
    {
        //instancia del servicio encargado de proveer los metodos
        public ServiceEstudiantes servicio = new ServiceEstudiantes();
        
        public EstudianteController()
        {

        }
        [HttpGet]
        public ActionResult Index()
        {
            var estudiante = servicio.obtenerTodos();
            return View(estudiante);
        }
        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var estudiante = new Estudiante();
            if (id.HasValue)
                estudiante = servicio.obtenerPorId(id.Value);

            ViewData["Operacion"] = operacion;
            return View(estudiante);
        }
        [HttpPost]
        public ActionResult Form(Estudiante estudiante)
        {
            try
            {
                if (estudiante.id == 0)
                    servicio.insertar(estudiante);
                else
                    servicio.modificar(estudiante.id, estudiante);
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