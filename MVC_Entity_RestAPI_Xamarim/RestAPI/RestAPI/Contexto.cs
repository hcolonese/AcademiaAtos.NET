
using Microsoft.EntityFrameworkCore;
using RestAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI
{
    public class Contexto :DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Contexto()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " +
                "initial Catalog=PrimeiroRestAPI;User ID=PrimeiroRestAPI; " +
                "password=PrimeiroRestAPI;language=Portuguese;Trusted_Connection=True;" +
                "TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Email>()
        //        .HasOne(e => e.pessoa)
        //        .WithMany(e => e.Emails)
        //        .OnDelete(DeleteBehavior.ClientCascade);
        //}
    }
}
