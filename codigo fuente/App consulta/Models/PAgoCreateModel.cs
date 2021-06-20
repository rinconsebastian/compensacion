using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace App_consulta.Models
{
    public class PAgoCreateModel
    {

        [Required]
        public int staticcedula { get; set; }

        public string staticnombre { get; set; }

        public DateTime staticdate { get; set; }

        public int staticnumero { get; set; }

        public int inputvalor { get; set; }


        public string inputadjunto_upload_cedula { get; set; }

        public string inputadjunto_upload_comprobante { get; set; }



    }
}
