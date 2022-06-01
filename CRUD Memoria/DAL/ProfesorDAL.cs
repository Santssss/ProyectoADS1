using CRUD_Memoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.DAL
{
    public class ProfesorDAL
    {
        public static List<Profesor> lstProfesor = new List<Profesor>();

        public ProfesorDAL()
        {

        }

        public int insertarProfesor(Profesor profesor)
        {
            try
            {
                if (lstProfesor.Count > 0)
                    profesor.Id = lstProfesor.Last().Id + 1;
                else
                    profesor.Id = 1;

                lstProfesor.Add(profesor);
                return profesor.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int modificarProfesor(int id, Profesor profesor)
        {
            try
            {
                lstProfesor[lstProfesor.FindIndex(temp => temp.Id == id)] = profesor;
                return profesor.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarProfesor(int id)
        {
            try
            {
                lstProfesor.RemoveAt(lstProfesor.FindIndex(aux => aux.Id == id));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Profesor> obtenerTodos()
        {
            return lstProfesor;
        }

        public Profesor obtenerPorId(int id)
        {
            try
            {
                Profesor profesor = lstProfesor.Find(temp => temp.Id == id);
                return profesor;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}