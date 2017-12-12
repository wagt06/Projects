using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sofia.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60,ErrorMessage ="El Campo {0} no debe de exeder los {1} Caracteres")]
        public string Nombre { get; set; }

        [StringLength(100, ErrorMessage = "El Campo {0} no debe de exeder los {1} Caracteres")]
        public string Descripcion { get; set; }

        public decimal  Precio { get; set; }

        public int Stock { get; set; }

        public int IdProveedor { get; set; }

        public List<Proveedor> Proveedor { get; set; }
    }

}