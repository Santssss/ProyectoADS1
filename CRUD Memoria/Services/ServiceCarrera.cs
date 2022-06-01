using CRUD_Memoria.DAL;
using CRUD_Memoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.Services
{
    public class ServiceCarrera
    {
        public CarreraDAL carreraDAL = new CarreraDAL();

        public int insertar(Carrera carrera)
        {
            try
            {
                return carreraDAL.insertarCarrera(carrera);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int modificar(int id, Carrera carrera)
        {
            try
            {
                return carreraDAL.modificarCarrera(id, carrera);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminar(int id)
        {
            try
            {
                return carreraDAL.eliminarCarrera(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Carrera> obtenerTodos()
        {
            return carreraDAL.obtenerTodos();
        }
        public Carrera obtenerPorId(int id)
        {
            try
            {
                return carreraDAL.obtenerPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}