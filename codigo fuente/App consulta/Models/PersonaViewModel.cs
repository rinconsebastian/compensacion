using System;
using System.ComponentModel.DataAnnotations;

namespace App_consulta.Models
{
	public class PersonaViewModel
    {


        [Required]
        [Key]
        [Display(Name = "Cedula")]
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


        [Display(Name = "Playa")]
        public string Playa { get; set; }


        [Display(Name = "Actividad")]
        public string Actividad { get; set; }


        public int Pagos { get; set; }
    }
}