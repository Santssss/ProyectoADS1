using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRUD_Memoria.Models;

namespace CRUD_Memoria.DAL
{
    public class GrupoDAL
    {
        public static List<Grupo> lstGrupo = new List<Grupo>();

        public GrupoDAL()
        {

        }

        public int insertarGrupo(Grupo grupo)
        {
            try
            {
                if (lstGrupo.Count > 0)
                    grupo.Id = lstGrupo.Last().Id + 1;
                else
                    grupo.Id = 1;

                lstGrupo.Add(grupo);
                return grupo.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public int modificarGrupo(int id, Grupo grupo)
        {
            try
            {
                lstGrupo[lstGrupo.FindIndex(temp => temp.Id == id)] = grupo;
                return grupo.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool eliminarGrupo(int id)
        {
            try
            {
                lstGrupo.RemoveAt(lstGrupo.FindIndex(aux => aux.Id == id));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Grupo> obtenerTodos()
        {
            return lstGrupo;
        }

        public Grupo obtenerPorId(int id)
        {
            try
            {
                Grupo grupo = lstGrupo.Find(temp => temp.Id == id);
                return grupo;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}