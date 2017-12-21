using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace ApiRestInventario.Controllers
{
    public class ProductosController : ApiController
    {
        public IEnumerable<Models.Productos> Get()
        {
            List<Models.Productos> Productos = new List<Models.Productos>();
            using (Models.InventarioModel modelo = new Models.InventarioModel()) {

                Productos = modelo.Productos.ToList();

            }
            return Productos;
        }

        // GET api/values/5
        public Models.Productos Get(int id)
        {
            var producto = new Models.Productos();
            using (Models.InventarioModel modelo = new Models.InventarioModel())
            {
                producto = modelo.Productos.Where(x => x.Id == id.ToString()).SingleOrDefault();
            }
            return producto;
        }

        // POST api/values
        public void Post([FromBody]Models.Productos value)
        {
            using (Models.InventarioModel modelo = new Models.InventarioModel())
            {
                modelo.Productos.Add(value);
                modelo.SaveChanges();
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Models.Productos value)
        {
            var producto = new Models.Productos();
            using (Models.InventarioModel modelo = new Models.InventarioModel())
            {
                producto = modelo.Productos.Where(x => x.Id == id.ToString()).SingleOrDefault();
                producto.Nombre = value.Nombre;
                producto.Descripcion = value.Descripcion;
                producto.Fecha = value.Fecha;
                producto.Cantidad = value.Cantidad;
                producto.Precio = value.Precio;
                modelo.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void Delete(string id)
        {
            var producto = new Models.Productos();
            using (Models.InventarioModel modelo = new Models.InventarioModel())
            {
                producto = modelo.Productos.Where(x => x.Id == id).SingleOrDefault();
                modelo.Productos.Remove(producto);
                modelo.SaveChanges();
            }
        }

    }
}
