using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD_Memoria.Models;
namespace CRUD_Memoria.DAL
{
    public class EstudianteDAL
    {
        public static List<Estudiante> lstEstudiantes = new List<Estudiante>();

        public EstudianteDAL()
        {

        }
        public int insertarEstudiante(Estudiante estudiante)
        {
            try
            {
                if (lstEstudiantes.Count > 0)
                    estudiante.id = lstEstudiantes.Last().id + 1;
                else
                    estudiante.id = 1;

                lstEstudiantes.Add(estudiante);
                return estudiante.id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int modificarEstudiante(int id, Estudiante estudiante)
        {
            try
            {
                lstEstudiantes[lstEstudiantes.FindIndex(temp => temp.id == id)] = estudiante;
                return estudiante.id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool eliminarEstudiante(int id)
        {
            try
            {
                lstEstudiantes.RemoveAt(lstEstudiantes.FindIndex(aux => aux.id == id));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Estudiante> obtenerTodos()
        {
            return lstEstudiantes;
        }
        public Estudiante obtenerPorId(int id)
        {
            try
            {
                Estudiante estudiante = lstEstudiantes.Find(temp=> temp.id == id);
                return estudiante;
            }
            catch (Exception)
            {

                throw;
            }
        }
            
    }
}