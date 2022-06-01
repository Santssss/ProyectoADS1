using CRUD_Memoria.DAL;
using CRUD_Memoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.Services
{
    public class ServiceMateria
    {
        public MateriaDAL materiaDAL = new MateriaDAL();

        public int insertar(Materia materia)
        {
            try
            {
                return materiaDAL.insertarMateria(materia);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int modificar(int id, Materia materia)
        {
            try
            {
                return materiaDAL.modificarMateria(id, materia);
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
                return materiaDAL.eliminarMateria(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Materia> obtenerTodos()
        {
            return materiaDAL.obtenerTodos();
        }
        public Materia obtenerPorId(int id)
        {
            try
            {
                return materiaDAL.obtenerPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}