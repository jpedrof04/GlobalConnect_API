using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlobalConnect.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalConnect.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Usuario> Usuarios {get;set;}
    }
}