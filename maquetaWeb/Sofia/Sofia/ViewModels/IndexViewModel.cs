using Sofia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sofia.ViewModels
{
    public class IndexViewModel : BaseModelo
    {

        /// <summary>
        /// todas las listas donde se mostrara el paginador 
        /// </summary>
        public List<Cliente> Clientes { get; set; }
    }
}