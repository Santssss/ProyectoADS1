using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.Models
{
    public class Grupo
    {
        public int Id { get; set; }
        
        public int IdCarrera { get; set; }
       
        public int IdMateria { get; set; }
       
        public int IdProfesor { get; set; }
        
        public int Ciclo { get; set; }
       
        public int Anio { get; set; }
    }
}