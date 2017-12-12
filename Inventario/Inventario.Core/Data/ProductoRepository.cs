using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Inventario.Core.Models;

namespace Inventario.Core.Data
{
    public  class ProductoRepository
    {
         internal List<Productos> _ListaProductos;
 

        public ProductoRepository()
        {
            _ListaProductos = new List<Productos>() {
                new Productos(){
                    IdProducto=1,
                    Nombre = "Samsumg Galaxy S4",
                    Descripcion ="Pantallas 5 in procesador dual core",
                    Cantidad = 5,
                    Precio = 140
                },
                 new Productos(){
                    IdProducto=2,
                    Nombre = "Samsumg one Note 4",
                    Descripcion ="Pantallas 6.5 in procesador dual core",
                    Cantidad = 5,
                    Precio = 140
                },
                  new Productos(){
                    IdProducto=3,
                    Nombre = "Samsumg Duo J5",
                    Descripcion ="Pantallas 4 in procesador dual core",
                    Cantidad = 5,
                    Precio = 120
                }

            };
        }

       internal List<Productos> GetProductos()
        {
            return _ListaProductos;
        }

        internal Productos GetProductoByID(int Id) {
            return _ListaProductos.FirstOrDefault(x => x.IdProducto == Id);

        }
    }
}