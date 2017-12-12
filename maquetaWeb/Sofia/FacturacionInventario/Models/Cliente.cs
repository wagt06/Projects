using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacturacionInventario.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100,ErrorMessage ="{0} no dene de superar los {1}")]
        public string Cedula { get; set; }

        [StringLength(100,ErrorMessage ="{0} no debe de superar los {1}")]
        public string Nombres { get; set; }

        [StringLength(100, ErrorMessage = "{0} no debe de superar los {1}")]
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

        public DateTime FechaAlta { get; set; }

        public DateTime FechaBaja { get; set; }









    }
}