using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sofia.ViewModels;
using System.Web.Routing;

namespace Sofia.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index(decimal? LimiteCredito, int pagina = 1)
        {
            //List<Models.Cliente> cl = Repositorios.RepCliente.Lista();
            //return View(cl);

            var cantidadRegistrosPorPagina =10; // parámetro
            using (var db = new Models.SofiaDb())
            {

                Func<Models.Cliente, bool> predicado = x => !LimiteCredito.HasValue || LimiteCredito.Value == x.LimiteCredito;

                var clientes = db.Cliente.Where(predicado).OrderBy(x => x.Id)
                    .Skip((pagina - 1) * cantidadRegistrosPorPagina)
                    .Take(cantidadRegistrosPorPagina).ToList();
                var totalDeRegistros = db.Cliente.Where(predicado).Count();

                var modelo = new IndexViewModel();
                modelo.Clientes = clientes;
                modelo.PaginaActual = pagina;
                modelo.TotalDeRegistros = totalDeRegistros;
                modelo.RegistrosPorPagina = cantidadRegistrosPorPagina;
                modelo.ValoresQueryString = new RouteValueDictionary();
                modelo.ValoresQueryString["LimiteCredito"] = LimiteCredito;

                return View(modelo);
            }
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create(int? id)
        {
            if (id != null)
            {
                ViewBag.titulo = "Actualizar Cliente";
                ViewBag.Estado = "Edit";
                Models.Cliente cl = Repositorios.RepCliente.BuscarCLiente(id);
                return View(cl);

            }
            ViewBag.titulo = "Nuevo Cliente";
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Models.Cliente collection)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    Repositorios.RepCliente.AddCliente(collection);
                    return RedirectToAction("Index");
                }
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Models.Cliente collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repositorios.RepCliente.AddCliente(collection);
                    return RedirectToAction("Index");

                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Create");
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                if (!Repositorios.RepCliente.EliminarCliente(id))
                {


                }

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // POST: Cliente/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here
        //        if (!Repositorios.RepCliente.EliminarCliente(id)) {


        //        }

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return RedirectToAction("Index");
        //    }
        //}
    }

}
