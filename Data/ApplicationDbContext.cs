using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecaDoHass.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaDoHass.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }
}