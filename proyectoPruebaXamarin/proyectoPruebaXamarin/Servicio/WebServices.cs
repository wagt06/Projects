using proyectoPruebaXamarin.Vistas;
using System.Net;
using System.Web;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Collections;
using Xamarin.Forms;
using Android.Net;
using Java.Net;

namespace proyectoPruebaXamarin.Servicio
{
    public class WebServices

    {
        HttpClient client = new HttpClient();

        public async Task<string> GetAsync()
        {
            List<Modelo.Producto> lista = new List<Modelo.Producto>();
            try
            {
                HttpClient client = new HttpClient()
                {
                  //  Timeout = System.TimeSpan.FromMilliseconds(5000)
                };
                var response = await client.GetAsync("http://localhost/api/productos");

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return json;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return "";
        }
    }
 }

