using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_consulta.Models
{
    public class PagoModel
    {



        [Required]
        [Key]
        public int Id { get; set; }


        
        [Display(Name = "Valor pagado")]
        public int Valor { get; set; }


        [Display(Name = "Mes")]
        public string Mes { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }


        [Display(Name = "Id Usuario")]
        public string IdUsuario { get; set; }


        [Display(Name = "Nombre usuario")]
        public string Nombreusuario { get; set; }


        [Display(Name = "Soport 1")]
        public string Soporte1 { get; set; }

        [Display(Name = "Soport 2")]
        public string Soporte2 { get; set; }

        [Display(Name = "Soport 3")]
        public string Soporte3 { get; set; }



        [Display(Name = "Persona")]
        public int IdPersona { get; set; }
        [ForeignKey("IdPersona")]
        public virtual PersonaModel Persona { get; set; }


    }
}
