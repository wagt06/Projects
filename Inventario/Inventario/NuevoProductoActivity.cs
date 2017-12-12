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

namespace Inventario
{
    [Activity(Label = "Nuevo Producto",MainLauncher =true)]
    public class NuevoProductoActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NuevoProducto);

            var nombre = FindViewById<EditText>(Resource.Id.Nombre);
            var descripcion = FindViewById<EditText>(Resource.Id.Descripcion);
            var precio = FindViewById<EditText>(Resource.Id.Precio);
            var cantidad = FindViewById<EditText>(Resource.Id.Cantidad);
            var button = FindViewById<Button>(Resource.Id.btnGuardar);
            // Create your application here

            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Hola mundo", ToastLength.Short).Show();
        }
    }
}