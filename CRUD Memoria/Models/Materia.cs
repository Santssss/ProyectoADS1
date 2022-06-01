using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.Models
{
    public class Materia
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }
    }
}