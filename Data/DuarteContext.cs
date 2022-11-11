using Duarte_api.Models;
using Microsoft.EntityFrameworkCore;

namespace Duarte_api.NovaPasta3
{
    public class DuarteContext:DbContext
    {
        public DuarteContext(DbContextOptions<DuarteContext> options)
          :base()
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefa { get; set; }
        protected override void OnModelCreating (ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
        }
    }
}