using Microsoft.EntityFrameworkCore;
using MyProyecto.CMD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProyecto.CMD
{
    internal class MyDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public MyDbContext() { }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;port=3306;Database=productos;User=root;Password=root;");
        }
    }
}
