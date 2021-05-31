using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_consulta.Models
{
    public class PersonaModel
    {



        [Required]
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Confianza")]
        public string Confianza { get; set; }


        [Required]
        [Display(Name = "Ambulante")]
        public bool Ambulante { get; set; }


        [Required]
        [Display(Name = "Edad")]
        public int Edad { get; set; }


        [Required]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Display(Name = "correo")]
        public string Correo { get; set; }


        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }


        [Display(Name = "Foto")]
        public string Foto { get; set; }


        [Display(Name = "Actividad")]
        public int IdActividad { get; set; }
        [ForeignKey("IdActividad")]
        public virtual ActividadModel Actividad { get; set; }


        [Display(Name = "Playa")]
        public int IdPlaya { get; set; }
        [ForeignKey("IdPlaya")]
        public virtual PlayaModel Playa { get; set; }


        [NotMapped]
        public virtual ICollection<PagoModel> Pagos { get; set; }
    }
}
