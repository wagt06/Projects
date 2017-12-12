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
    [Activity(Label = "Catalogo de Productos",MainLauncher =false)]
    public class CatProductosActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CatProductos);
            // Create your application here

            var listview = FindViewById<ListView>(Resource.Id.lvProductos);

            //adaptador crea las vistas del ListView
        }
    }
}