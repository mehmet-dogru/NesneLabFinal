using Microsoft.EntityFrameworkCore;
using MonitorApp.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorApp.DataAccess.Concrete.EntityFramework
{
    public class MonitorAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
          optionsBuilder)
        {
            optionsBuilder
               .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MonitorDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Monitor> Monitors { get; set; }
    }
}
