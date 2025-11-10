using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // server db (localhost)
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ToDoAppDb;Trusted_Connection=True;TrustServerCertificate=True;");

            // localdb
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TodoAppDb;Trusted_Connection=True;");
        }
    }
}
