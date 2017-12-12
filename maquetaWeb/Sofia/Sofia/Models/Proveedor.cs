using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sofia.Models
{
    public class Proveedor
    {
        [Key]
        public int Id { get; set; }

        public string NombreP { get; set; }

        public string Ruc { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Direccion { get; set; }

    
        public int IdProducto { get; set; }

        public List<Producto> Producto { get; set; }

    }
}