using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sofia.Repositorios
{
    public class RepCliente
    {
        public Models.Cliente cliente = new Models.Cliente();

        public static List<Models.Cliente> Lista()
        {

            List<Models.Cliente> lista = new List<Models.Cliente>();
            using (var db = new Models.SofiaDb())
            {
                lista = db.Cliente.ToList();
            }
            return lista;
        }

        public static Boolean AddCliente(Models.Cliente cl)
        {
            using (var db = new Models.SofiaDb())
            {
                try
                {

                    if (db.Cliente.Find(cl.Id) == null)
                    {
                        var respuesta = db.Cliente.Add(cl);
                    }
                    else
                    {
                        var cliente = db.Cliente.FirstOrDefault(x => x.Id == cl.Id);
                        db.Entry(cliente).State = System.Data.Entity.EntityState.Detached;
                        db.Entry(cl).State = System.Data.Entity.EntityState.Modified;
                    }

                    db.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw;
                }

            }
        }

        public static Models.Cliente BuscarCLiente(int? id)
        {
            using (var db = new Models.SofiaDb())
            {
                return (db.Cliente.Find(id));

            }
        }

        public static Boolean EliminarCliente(int id)
        {
            try
            {
                using (var db = new Models.SofiaDb())
                {
                    var cliente = db.Cliente.FirstOrDefault(x => x.Id == id);
                    db.Cliente.Remove(cliente);
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

    }
}


