using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD_Memoria.DAL;
using CRUD_Memoria.Models;

namespace CRUD_Memoria.Services
{
    public class ServiceEstudiantes
    {
        public EstudianteDAL estudianteDAL = new EstudianteDAL();

        public int insertar(Estudiante estudiante)
        {
            try
            {
                return estudianteDAL.insertarEstudiante(estudiante);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int modificar(int id, Estudiante estudiante)
        {
            try
            {
                return estudianteDAL.modificarEstudiante(id, estudiante);
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
                return estudianteDAL.eliminarEstudiante(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Estudiante> obtenerTodos()
        {
            return estudianteDAL.obtenerTodos();
        }
        public Estudiante obtenerPorId(int id)
        {
            try
            {
                return estudianteDAL.obtenerPorId(id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}