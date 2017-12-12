﻿using proyectoPruebaXamarin.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using proyectoPruebaXamarin.servicio;

namespace proyectoPruebaXamarin.Vistas
{
    public partial class ListaProductos : ContentPage
    {
        public ListaProductos()
        { 
            InitializeComponent();
            ObservableCollection<Producto> ListaProductos = new ObservableCollection<Producto>(new ServicioProducto().ListaProductos());
            lstPersonas.ItemsSource = ListaProductos;
        }
    }
}
