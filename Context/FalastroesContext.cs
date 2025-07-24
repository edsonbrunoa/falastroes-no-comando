using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using falastroes_no_comando.Models;
using Microsoft.EntityFrameworkCore;

namespace falastroes_no_comando.Context
{
    public class FalastroesContext : DbContext
    {
        public FalastroesContext(DbContextOptions<FalastroesContext> options) : base(options)
        {

        }

        public DbSet<Political> Politicals { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Political_has_Proposal> Political_Has_Proposals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Political>().ToTable("Political");
            modelBuilder.Entity<Proposal>().ToTable("Proposal");
            modelBuilder.Entity<Political_has_Proposal>().ToTable("Political_has_Proposal");
        }
    }
}