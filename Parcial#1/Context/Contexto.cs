using Parcial_1.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations;

namespace Parcial_1.Context
{
    public class Contexto : DbContext
    {
        public DbSet<Ingresos> Ingresos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
    }
}
