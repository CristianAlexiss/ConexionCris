using Microsoft.EntityFrameworkCore;
using ConexionCris.Models;

namespace ConexionCris.Context
{
    public class ContextCriss : DbContext
    {
        public ContextCriss(DbContextOptions<ContextCriss> ContextOptions) : base(ContextOptions)
        {
        }
        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Veterinario> veterinario {get; set;}
    }
}