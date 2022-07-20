using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje
{
    public class Context : DbContext
    {
        public DbSet<Firma> Firma { get; set; }
        public DbSet<Magacin> Magacin { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<StavkaRacuna> StavkaRacuna { get; set; }
        public DbSet<StavkaMagacina> StavkaMagacina { get; set; }
        public DbSet<Racun> Racun { get; set; }
        public DbSet<Promet> Promet { get; set; }

        public Context()
        {

        }
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Server=beograd\\sql2016;Database=MagacinskoPoslovanje;User ID=sa; Password=Beograd123#;Trusted_Connection=false;Persist Security Info=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Promet>()
             .HasOne<Firma>(x => x.Firma)
             .WithMany(g => g.Prometi)
             .HasForeignKey(x => x.FirmaId)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Promet>().
                HasOne<StavkaMagacina>(x => x.StavkaMagacina).
                WithMany(g => g.Prometi).
                HasForeignKey(x => x.StavkaMagacinaId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Racun>()
              .HasOne<Firma>(x => x.Firma)
              .WithMany(g => g.Racuni)
              .HasForeignKey(x => x.FirmaId)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StavkaRacuna>()
             .HasOne<Racun>(x => x.Racun)
             .WithMany(g => g.StavkeRacuna)
             .HasForeignKey(x => x.RacunId)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StavkaMagacina>().
                HasOne<Magacin>(x => x.Magacin).
                WithMany(g => g.StavkeMagacina).
                HasForeignKey(x => x.MagacinId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StavkaMagacina>().
                HasOne<Proizvod>(g => g.Proizvod)
                .WithMany(g => g.StavkeMagacina).
                HasForeignKey(x => x.ProizvodId)
                .OnDelete(DeleteBehavior.Restrict); ;

            modelBuilder.Entity<StavkaRacuna>().
                HasOne<StavkaMagacina>(g => g.StavkaMagacina).
                WithMany(g => g.StavkeRacuna).
                HasForeignKey(x => x.StavkaMagacinaId)
                .OnDelete(DeleteBehavior.Restrict); 
        }        
    }
}
