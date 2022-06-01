using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.Models
{
    public class Estudiante
    {
        public int id { get; set; }
        
        public string  codigo { get; set; }
        
        public string email { get; set; }

        
        public string nombres { get; set; }
        
        public string apellidos { get; set; }
    }
}