using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace proyectoPruebaXamarin.Servicio
{
    public class ProductoServicio
    {
        public ObservableCollection<Modelo.Producto> Producto { get; set; }
        //  public WebServices service = new WebServices();
        string prod;
        public ProductoServicio()
        {
            if (Producto == null) {
                Producto = new ObservableCollection<Modelo.Producto>();
               // ListaProductos();
            }
        }

        public ObservableCollection<Modelo.Producto> Consultar()
        {
            return Producto;
        }

        public void Guardar(Modelo.Producto modelo) {
            Producto.Add(modelo);

        }
        public void Modificar(Modelo.Producto modelo) {
            var items = Producto.Where(x => x.Id == modelo.Id).SingleOrDefault();
            items.Nombre = modelo.Nombre;
            items.Cantidad = modelo.Cantidad;
            items.Precio = modelo.Precio;
            items.Fecha = modelo.Fecha;
           
        }
        public void Eliminar(string id) {

            var items = Producto.Where(x => x.Id ==id).SingleOrDefault();
            Producto.Remove(items);
        }

        public async Task<ObservableCollection<Modelo.Producto>>ListaProductos() {

                WebServices services = new WebServices();
            prod = await  services.GetAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ObservableCollection<Modelo.Producto>>(prod);
  
      
        }

    }
}
