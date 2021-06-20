using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_consulta.Models
{
    public class AdjuntoModel
    {
        public bool Loaded { get; set; }

        public string Nombre { get; set; }

        public string Ruta { get; set; }
    }


    public class FormAdjuntoModel
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Ruta { get; set; }
    }
}
