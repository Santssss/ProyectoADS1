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
    public class GrupoController : Controller
    {
        public ServiceGrupo servicio = new ServiceGrupo();

        [HttpGet]
        public ActionResult Index()
        {
            var grupo = servicio.obtenerTodos();
            return View(grupo);
        }
        [HttpGet]
        public ActionResult Form(int? id, Operacion operacion)
        {
            var grupo = new Grupo();
            if (id.HasValue)
                grupo = servicio.obtenerPorId(id.Value);

            ViewData["Operacion"] = operacion;
            return View(grupo);
        }
        [HttpPost]
        public ActionResult Form(Grupo grupo)
        {
            try
            {
                if (grupo.Id == 0)
                    servicio.insertar(grupo);
                else
                    servicio.modificar(grupo.Id, grupo);
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