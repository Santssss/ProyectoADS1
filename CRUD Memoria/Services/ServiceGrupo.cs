using CRUD_Memoria.DAL;
using CRUD_Memoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.Services
{
    public class ServiceGrupo
    {

        public GrupoDAL grupoDAL = new GrupoDAL();

        public int insertar(Grupo grupo)
        {
            try
            {
                return grupoDAL.insertarGrupo(grupo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int modificar(int id, Grupo grupo)
        {
            try
            {
                return grupoDAL.modificarGrupo(id, grupo);
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
                return grupoDAL.eliminarGrupo(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Grupo> obtenerTodos()
        {
            return grupoDAL.obtenerTodos();
        }
        public Grupo obtenerPorId(int id)
        {
            try
            {
                return grupoDAL.obtenerPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}