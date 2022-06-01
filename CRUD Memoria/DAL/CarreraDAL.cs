using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD_Memoria.Models;

namespace CRUD_Memoria.DAL
{
    public class CarreraDAL
    {

        public static List<Carrera> lstCarrera = new List<Carrera>();

        public CarreraDAL()
        {

        }

        public int insertarCarrera(Carrera carrera)
        {
            try
            {
                if (lstCarrera.Count > 0)
                    carrera.Id = lstCarrera.Last().Id + 1;
                else
                    carrera.Id = 1;

                lstCarrera.Add(carrera);
                return carrera.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int modificarCarrera(int id, Carrera carrera)
        {
            try
            {
                lstCarrera[lstCarrera.FindIndex(temp => temp.Id == id)] = carrera;
                return carrera.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarCarrera(int id)
        {
            try
            {
                lstCarrera.RemoveAt(lstCarrera.FindIndex(aux => aux.Id == id));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Carrera> obtenerTodos()
        {
            return lstCarrera;
        }

        public Carrera obtenerPorId(int id)
        {
            try
            {
                Carrera carrera = lstCarrera.Find(temp=> temp.Id == id);
                return carrera;
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}