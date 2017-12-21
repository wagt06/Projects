using proyectoPruebaXamarin.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace proyectoPruebaXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductoPage : ContentPage
    {
        ProductoViewModel contexto = new ProductoViewModel();
        public ProductoPage(Modelo.Producto P)
        {
            InitializeComponent();
           
            contexto.Id = P.Id;
            contexto.Nombre = P.Nombre;
            contexto.Descripcion = P.Descripcion;
            contexto.Cantidad = P.Cantidad;
            contexto.Precio = P.Precio;
            contexto.Fecha = P.Fecha;
            BindingContext = contexto;
        }
    }
}
