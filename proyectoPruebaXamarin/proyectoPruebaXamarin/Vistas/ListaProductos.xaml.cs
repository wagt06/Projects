using proyectoPruebaXamarin.Modelo;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using proyectoPruebaXamarin.ViewModel;
using proyectoPruebaXamarin.Servicio;

namespace proyectoPruebaXamarin.Vistas
{
    public partial class ListaProductos : ContentPage
    {
        ProductoViewModel contexto = new ProductoViewModel();
        public ListaProductos()
        {
            InitializeComponent();
            BindingContext = contexto;
            CargarList();
            //lstPersonas.ItemsSource = contexto.Producto;
            lstPersonas.ItemSelected += LstPersonas_ItemSelected;
            btnNuevo.Clicked += BtnNuevo_Clicked;

        }

        private void BtnNuevo_Clicked(object sender, EventArgs e)
        {
            //var resultado = DisplayAlert("Aplicacion de inventarios", "este es el mensaje", "Aceptar", "Cancelar");
            Navigation.PushAsync(new Vistas.ProductoPage(new Producto()));
        }

        private void LstPersonas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null) {
                Modelo.Producto producto = (Modelo.Producto)e.SelectedItem;
                Navigation.PushAsync(new Vistas.ProductoPage(producto));

            }
        }

        private void CargarList() {

            Device.BeginInvokeOnMainThread(async () =>
            {
                ProductoServicio servicios = new ProductoServicio();
                contexto.Producto = await servicios.ListaProductos();
                lstPersonas.ItemsSource = contexto.Producto;
            });

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstPersonas.ItemsSource = contexto.Producto;
        }
    }
}
