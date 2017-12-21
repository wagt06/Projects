using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace proyectoPruebaXamarin.Modelo
{
   public  class Producto:INotifyPropertyChanged  ///implementando interfaz para usar propiedad notifychage que esta pendiente del cambio en el modelo
    {
        ///Propiedad que esta pendiene en el cambio del modelo
        public event PropertyChangedEventHandler PropertyChanged;

        //inicializando la propiedad ---callermembreName es un notation que genera el nombre de la propiedad
        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private Boolean isbusy;
        ///indica  si la aplicacion esta Ocupada asi el usuario no intentar ejecutar ninguna accion
        public Boolean Isbusy
        {
            get { return isbusy = false; }
            set { isbusy = value;
                OnPropertyChanged();
            }
            
        }


        private string id;

        public string Id
        {
            get { return id; }
            set { id = value;
                OnPropertyChanged(); ///por defecto toma el nombre de la propiedad
            }
            
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value;
                OnPropertyChanged();
            }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));
            }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value;
                OnPropertyChanged();
            }
        }


        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value;
                OnPropertyChanged();
            }
        }
        private string nombreCompleto;

        public string NombreCompleto
        {
            get { return $"{ Nombre}{" Cantidad: "}{cantidad}";
              
            }
            set
            {
                nombreCompleto = value;
                OnPropertyChanged(nameof(Mensaje));
            }

        }
        //private string mensaje;

        public string Mensaje
        {
            get { return $"Producto {NombreCompleto}"; }  ///solo regresa el nombre completo
        }







    }
}
