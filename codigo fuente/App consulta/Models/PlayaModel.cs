using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_consulta.Models
{
    public class PlayaModel
    {



        [Required]
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Display(Name = "Polígono")]
        public string Poligono { get; set; }



        [NotMapped]
        public virtual ICollection<PersonaModel> Personas { get; set; }




    }
}
