using System;
using EFDtataAccessLibary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFDtataAccessLibary.DataAccess
{
    public partial class GewertsContext : DbContext
    {
        public GewertsContext()
        {
        }

        public GewertsContext(DbContextOptions<GewertsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bokförlag> Bokförlags { get; set; }
        public virtual DbSet<Butiker> Butikers { get; set; }
        public virtual DbSet<Böcker> Böckers { get; set; }
        public virtual DbSet<Dagsförsäljning> Dagsförsäljnings { get; set; }
        public virtual DbSet<Författare> Författares { get; set; }
        public virtual DbSet<FörfattareBöcker> FörfattareBöckers { get; set; }
        public virtual DbSet<FörsäljningsStatistik> FörsäljningsStatistiks { get; set; }
        public virtual DbSet<Inköpsorder> Inköpsorders { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldos { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<TitlarPerFörfattare> TitlarPerFörfattares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-0552K6O6;Database=Gewerts;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Bokförlag>(entity =>
            {
                entity.HasKey(e => e.Namn)
                    .HasName("PK__Bokförla__737584FC193FA552");

                entity.Property(e => e.Namn).IsUnicode(false);

                entity.Property(e => e.Land).IsUnicode(false);
            });

            modelBuilder.Entity<Butiker>(entity =>
            {
                entity.Property(e => e.Gatuadress).IsUnicode(false);

                entity.Property(e => e.Namn).IsUnicode(false);

                entity.Property(e => e.Ort).IsUnicode(false);
            });

            modelBuilder.Entity<Böcker>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PK__Böcker__447D36EB71DD55AF");

                entity.Property(e => e.Isbn).ValueGeneratedNever();

                entity.Property(e => e.BokförlagNamn).IsUnicode(false);

                entity.Property(e => e.Språk).IsUnicode(false);

                entity.Property(e => e.Titel).IsUnicode(false);

                entity.HasOne(d => d.BokförlagNamnNavigation)
                    .WithMany(p => p.Böckers)
                    .HasForeignKey(d => d.BokförlagNamn)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Böcker__Bokförla__2B3F6F97");
            });

            modelBuilder.Entity<Dagsförsäljning>(entity =>
            {
                entity.HasKey(e => new { e.ButiksId, e.Datum })
                    .HasName("PK__Dagsförs__701907C05D942E2C");

                entity.HasOne(d => d.Butiks)
                    .WithMany(p => p.Dagsförsäljnings)
                    .HasForeignKey(d => d.ButiksId)
                    .HasConstraintName("FK__Dagsförsä__Butik__35BCFE0A");
            });

            modelBuilder.Entity<Författare>(entity =>
            {
                entity.Property(e => e.Efternamn).IsUnicode(false);

                entity.Property(e => e.Förnamn).IsUnicode(false);
            });

            modelBuilder.Entity<FörfattareBöcker>(entity =>
            {
                entity.HasKey(e => new { e.Isbn, e.FörfattareId })
                    .HasName("PK__Författa__5C7927A686F247B3");

                entity.HasOne(d => d.Författare)
                    .WithMany(p => p.FörfattareBöckers)
                    .HasForeignKey(d => d.FörfattareId)
                    .HasConstraintName("FK__Författar__Förfa__3C69FB99");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.FörfattareBöckers)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Författare__ISBN__3D5E1FD2");
            });

            modelBuilder.Entity<FörsäljningsStatistik>(entity =>
            {
                entity.ToView("FörsäljningsStatistik");

                entity.Property(e => e.Namn).IsUnicode(false);
            });

            modelBuilder.Entity<Inköpsorder>(entity =>
            {
                entity.HasKey(e => new { e.Ordernummer, e.Isbn })
                    .HasName("PK__Inköpsor__4613DB21E9FA3B2C");

                entity.HasOne(d => d.Butiks)
                    .WithMany(p => p.Inköpsorders)
                    .HasForeignKey(d => d.ButiksId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Inköpsord__Butik__32E0915F");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.Inköpsorders)
                    .HasForeignKey(d => d.Isbn)
                    .HasConstraintName("FK__Inköpsorde__ISBN__31EC6D26");
            });

            modelBuilder.Entity<LagerSaldo>(entity =>
            {
                entity.HasKey(e => new { e.Isbn, e.ButiksId })
                    .HasName("PK__LagerSal__D6C35890ACC28E44");

                entity.HasOne(d => d.Butiks)
                    .WithMany(p => p.LagerSaldos)
                    .HasForeignKey(d => d.ButiksId)
                    .HasConstraintName("FK__LagerSald__Butik__2F10007B");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.LagerSaldos)
                    .HasForeignKey(d => d.Isbn)
                    .HasConstraintName("FK__LagerSaldo__ISBN__2E1BDC42");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.Anställningsnummer)
                    .HasName("PK__Personal__A6FF8FFFF6087420");

                entity.Property(e => e.Efternamn).IsUnicode(false);

                entity.Property(e => e.Förnamn).IsUnicode(false);

                entity.HasOne(d => d.ArbetsplatsButiks)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.ArbetsplatsButiksId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Personal__Arbets__38996AB5");
            });

            modelBuilder.Entity<TitlarPerFörfattare>(entity =>
            {
                entity.ToView("TitlarPerFörfattare");

                entity.Property(e => e.Namn).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
