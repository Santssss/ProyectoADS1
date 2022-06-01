using CRUD_Memoria.DAL;
using CRUD_Memoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.Services
{
    public class ServiceProfesor
    {
        public ProfesorDAL profesorDAL = new ProfesorDAL();

        public int insertar(Profesor profesor)
        {
            try
            {
                return profesorDAL.insertarProfesor(profesor);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int modificar(int id, Profesor profesor)
        {
            try
            {
                return profesorDAL.modificarProfesor(id, profesor);
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
                return profesorDAL.eliminarProfesor(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Profesor> obtenerTodos()
        {
            return profesorDAL.obtenerTodos();
        }
        public Profesor obtenerPorId(int id)
        {
            try
            {
                return profesorDAL.obtenerPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}