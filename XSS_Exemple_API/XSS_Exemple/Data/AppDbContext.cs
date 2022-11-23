using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XSS_Exemple.Models;

namespace XSS_Exemple.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Tokens> Tokens { get; set; }

    }
}
