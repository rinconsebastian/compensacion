using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_consulta.Models
{
    public class ActividadModel
    {



        [Required]
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }



        [Required]
        [Display(Name = "Valor a compensar")]
        public int Valor { get; set; }






        [NotMapped]
        public virtual ICollection<PersonaModel> Personas { get; set; }

    }
}
