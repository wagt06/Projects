using proyectoPruebaXamarin.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPruebaXamarin.servicio
{
    public class ServicioProducto
    {
        public List<Producto> ListaProductos() {
            List<Producto> _listaProductos = new List<Producto>();
            _listaProductos.Add(
                new Producto {
                   CodProducto = 1234,
                    NombreProducto = "Laptop 2570P",
                    Descripcion = "Descripcion de este Producto",
                    Fecha = "28/10/2017" });
            _listaProductos.Add(new Producto
                  {
                CodProducto = 23423,
                NombreProducto = "Monito HP C-123",
                      Descripcion = "Monitor de 21 pulgadas",
                      Fecha = "18/10/2017"
            }
                );
            _listaProductos.Add(new Producto
            {
                CodProducto = 1233,
                NombreProducto = "Monito HP C-1234",
                Descripcion = "Monitor de 21 pulgadas",
                Fecha = "18/10/2017"
            }
             );
            _listaProductos.Add(new Producto
            {
                CodProducto = 55677,
                NombreProducto = "Monito HP C-123",
                Descripcion = "este es otro monitor",
                Fecha = "18/10/2017"
            }
             );
            _listaProductos.Add(new Producto
            {
                CodProducto = 4453,
                NombreProducto = "Telefono LG123",
                Descripcion = "Monitor de 21 pulgadas",
                Fecha = "18/10/2017"
            }
             );
            _listaProductos.Add(new Producto
            {
                CodProducto = 5678,
                NombreProducto = "Tablet 19In RCA",
                Descripcion = "Tablets de 10 pulgadas",
                Fecha = "18/10/2017"
            }
             );

            return _listaProductos;
        }
    }
}
