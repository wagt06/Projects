using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using 

namespace Sofia.Repositorios
{
    public class RepProducto
    {
        public static List<Models.Proveedor> Lista()
        {
            try
            {
                using (var db = new SofiaDb())
                {
                    var proveedores = db.Proveedor.ToList();
                    return proveedores;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool GuardarProveedor(Models.Proveedor pro)
        {
            try
            {
                using (var db = new SofiaDb())
                {
                    db.Proveedor.Add(pro);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public static bool ActualizarProveedor(Models.Producto pro)
        {
            try
            {
                using (var db = new SofiaDb())
                {

                    db.Entry(pro).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        public static Models.Proveedor BuscarProveedor(int pro)
        {
            try
            {
                using (var db = new SofiaDb())
                {
                    var proveedor = db.Proveedor.Find(pro);
                    return proveedor;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}