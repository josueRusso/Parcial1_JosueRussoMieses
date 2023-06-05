using Parcial_1.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;
using Parcial_1.Context;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Parcial_1.BLL
{
    public class IngresosBLL
    {
        public Contexto _contexto;

        public IngresosBLL (Contexto contexto)
        {
            _contexto = contexto;
        }

        public bool Existe(int ingresoId)
        {
            return _contexto.Ingresos.Any(i => i.IngresoId == ingresoId);
        }

        private bool Insertar(Ingresos ingresos) 
        {
            _contexto.Ingresos.Add(ingresos);
            var verificar = _contexto.SaveChanges();
            return verificar > 0;
        }

        private bool Modificar(Ingresos ingresos)
        {
            _contexto.Ingresos.Update(ingresos);
            var Verificar = _contexto.SaveChanges();
            return Verificar > 0;
        }

        public bool Guardar(Ingresos ingresos)
        {
            if (!Existe(ingresos.IngresoId))
                return Insertar(ingresos);
            else
                return Modificar(ingresos);
        }

        public bool Eliminar(Ingresos ingresos)
        {
            _contexto.Ingresos.Remove(ingresos);
            var verificare = _contexto.SaveChanges();
            return verificare > 0;
        }

        public Ingresos? Buscar(int IngresosId)
        {
            return _contexto.Ingresos.AsNoTracking().FirstOrDefault(i => i.IngresoId == IngresosId);
        }
        
    }
}
