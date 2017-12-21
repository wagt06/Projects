using proyectoPruebaXamarin.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace proyectoPruebaXamarin.ViewModel
{
    public class ProductoViewModel:Modelo.Producto
    {
        public ObservableCollection<Modelo.Producto> Producto { get; set; }
        ProductoServicio Servicio = new ProductoServicio();
        Modelo.Producto modelo;

        public ProductoViewModel()
        {
            Servicio.Consultar();
            ///el metodo asincrono espera que se ejecute el metodo guardar, y se puede ejecutar mientras la propiedad no este ocupad
 
            GuardarCommand = new Command( async() => await Guardar(),() => !Isbusy);
            ModificarCommnand = new Command(async () => await Modificar(), () => !Isbusy);
            EliminarCommand = new Command(async () => await Elimiar(), () => !Isbusy);
            LimpiarCommand = new Command(Limpiar);

        }
        public Command GuardarCommand { get; set; }
        public Command ModificarCommnand { get; set; }
        public Command EliminarCommand { get; set; }
        public Command LimpiarCommand { get; set; }
        public string  ListarProductos { get; set; }

        private async Task Guardar() {
            Isbusy = true;
            Guid idProducto = Guid.NewGuid();

            modelo = new Modelo.Producto()
            {
                Id = idProducto.ToString(),
                Nombre = Nombre,
                Descripcion = Descripcion,
                Precio = Precio,
                Fecha = Fecha,
                Cantidad = Cantidad
            };
            Servicio.Guardar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }
        private async Task Modificar()
        {
            Isbusy = true;
            modelo = new Modelo.Producto()
            {
                Id = Id,
                Nombre = Nombre,
                Descripcion = Descripcion,
                Precio = Precio,
                Fecha = Fecha,
                Cantidad = Cantidad
            };
            Servicio.Modificar(modelo);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private async Task Elimiar()
        {
            Isbusy = true;
            Servicio.Eliminar(Id);
            await Task.Delay(2000);
            Isbusy = false;
        }

        private void Limpiar() {
            Id = "";
            Nombre = "";
            Descripcion = "";
            Precio = 0;
            Fecha =  DateTime.Today;
        }


    }
}
