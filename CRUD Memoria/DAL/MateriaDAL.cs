using CRUD_Memoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.DAL
{
    public class MateriaDAL
    {
        public static List<Materia> lstMateria = new List<Materia>();

        public MateriaDAL()
        {

        }

        public int insertarMateria(Materia materia)
        {
            try
            {
                if (lstMateria.Count > 0)
                    materia.Id = lstMateria.Last().Id + 1;
                else
                    materia.Id = 1;

                lstMateria.Add(materia);
                return materia.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int modificarMateria(int id, Materia materia)
        {
            try
            {
                lstMateria[lstMateria.FindIndex(temp => temp.Id == id)] = materia;
                return materia.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarMateria(int id)
        {
            try
            {
                lstMateria.RemoveAt(lstMateria.FindIndex(aux => aux.Id == id));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Materia> obtenerTodos()
        {
            return lstMateria;
        }

        public Materia obtenerPorId(int id)
        {
            try
            {
                Materia materia = lstMateria.Find(temp => temp.Id == id);
                return materia;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}