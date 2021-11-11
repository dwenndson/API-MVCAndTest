using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models.Contexto
{
    public class Contexto :  DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }   
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer(connectionString: @"Server=(localdb)\MSSQLLocalDB;Database=Cursomvc;");
        }
    }
}
