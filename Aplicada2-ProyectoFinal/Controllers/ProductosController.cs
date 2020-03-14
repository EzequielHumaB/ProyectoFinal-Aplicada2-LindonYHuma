using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicada2_ProyectoFinal.Models;
using Aplicada2_ProyectoFinal.Data;

namespace Aplicada2_ProyectoFinal.Controllers
{
    public class ProductosController
    {
        public bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Productos.Any(A => A.ProductoId == productos.ProductoId))
                {
                    paso = Modificar(productos);
                }
                else
                {
                    paso = Insertar(productos);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }


        private bool Insertar(Productos productos)
        {
            Contexto db = new Contexto();
            bool paso = false;

            try
            {
                db.Productos.Add(productos);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }

            return paso;
        }

        private bool Modificar(Productos productos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(productos).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                Productos productos = db.Productos.Find(id);
                if (productos != null)
                {
                    db.Entry(productos).State = EntityState.Deleted;
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public Productos Buscar(int id)
        {
            Productos productos = new Productos();
            Contexto db = new Contexto();
            try
            {
                productos = db.Productos.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            return productos;
        }

        public List<Productos> GetList(Expression<Func<Productos, bool>> expression)
        {
            Contexto db = new Contexto();
            List<Productos> lista = new List<Productos>();

            try
            {
                lista = db.Productos.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
    }
}
