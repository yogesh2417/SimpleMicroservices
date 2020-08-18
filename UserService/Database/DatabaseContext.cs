using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.Database.Entitites;

namespace UserService.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DEL1-LHP-N01543;initial catalog=MicroserviceDemo;persist security info=True; Integrated Security=SSPI;");
        }
    }
}
