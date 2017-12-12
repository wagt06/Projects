using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sofia.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [StringLength(14,ErrorMessage ="{0} no debe de superar los {1}")]
        public string Cedula { get; set; }

        [StringLength(80,ErrorMessage ="{0} no debe de superar los {1}")]
        public string Nombres { get; set; }

        [StringLength(80, ErrorMessage = "{0} no debe de superar los {1}")]
        public string Apellidos { get; set; }


        [StringLength(200, ErrorMessage = "{0} no debe de superar los {1}")]
        [DataType(DataType.MultilineText)]
        public string Direccion { get; set; }
        [Display(Name="Email")]
        public string CorreoElectronico { get; set; }

        public string Ciudad { get; set; }

        public string Departamento { get; set; }
        [Display(Name ="Limite de Credito")]
        public decimal LimiteCredito { get; set; }

       









    }
}