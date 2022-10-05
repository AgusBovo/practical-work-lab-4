using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using WebAppMVC_EF.Models;

namespace WebAppMVC_EF.Models
{
    public class appDBcontext : DbContext
    {
        public appDBcontext()
        {
        }

        public appDBcontext(DbContextOptions<appDBcontext> options)
         : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(connectionString: "Filename=PruebasSQLite.db",
        //        sqliteOptionsAction: op =>
        //        {
        //            op.MigrationsAssembly(
        //                Assembly.GetExecutingAssembly().FullName
        //                );
        //        });
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-QLCRKBB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}

       
        public DbSet<WebAppMVC_EF.Models.Book> Book { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(connectionString: "Filename=PruebasSQLite.db",
        //        sqliteOptionsAction: op =>
        //        {
        //            op.MigrationsAssembly(
        //                Assembly.GetExecutingAssembly().FullName
        //                );
        //        });
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-QLCRKBB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}

       
        public DbSet<WebAppMVC_EF.Models.Author> Author { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite(connectionString: "Filename=PruebasSQLite.db",
        //        sqliteOptionsAction: op =>
        //        {
        //            op.MigrationsAssembly(
        //                Assembly.GetExecutingAssembly().FullName
        //                );
        //        });
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=DESKTOP-QLCRKBB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}

       
        public DbSet<WebAppMVC_EF.Models.Genre> Genre { get; set; }
    }

}
