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
using Inventario.Core.Data;

namespace Inventario.Core.Services
{
    class ProductosServices
    {
        private ProductoRepository _productoRepository;

        public ProductosServices() {

            _productoRepository = new ProductoRepository();

        }
        public List<Models.Productos> ListaProductos() {

            return _productoRepository.GetProductos();

        }

        public Models.Productos ProductoId(int Id) {
            return _productoRepository.GetProductoByID(Id);
        }

    }
}