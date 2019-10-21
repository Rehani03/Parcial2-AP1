using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2_AP1.Entidades;
using Parcial2_AP1.BLL;
using Parcial2_AP1.DAL;
using System.Data.Entity;

namespace Parcial2_AP1.BLL
{
    public class RepositorioVenta : RepositorioBase<Venta>
    {
        public override bool Guardar(Venta venta)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Venta.Add(venta) != null)
                    paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;

        }
        public override bool Modificar(Venta venta)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Venta> repositorio = new RepositorioBase<Venta>();
            try
            {
                var Anterior = repositorio.Buscar(venta.VentaID);
                foreach (var item in Anterior.Servicios)
                {
                    if (!venta.Servicios.Exists(d => d.DetalleVentaID == item.DetalleVentaID))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                db.Entry(venta).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
    }
}
