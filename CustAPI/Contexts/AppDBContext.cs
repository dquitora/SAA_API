using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustAPI.Contexts
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }               
        
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Autores> Autores { get; set; }

    }
}
