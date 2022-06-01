using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Memoria.Models
{
    public class Profesor
    {
        public int Id { get; set; }
       
        public string Nombres { get; set; }
       
        public string Apellidos { get; set; }
       
        public string Email { get; set; }
    }
}