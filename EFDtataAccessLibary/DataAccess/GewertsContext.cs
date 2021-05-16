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
                optionsBuilder.UseSqlServer("Server=LAPTOP-0552K6O6;Database=Gewerts;Trusted_Connection=True;"); //<--- Klipp in din ConnectionString här!!
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Finnish_Swedish_CI_AS");

            modelBuilder.Entity<Bokförlag>(entity =>
            {
                entity.HasKey(e => e.Namn)
                    .HasName("PK__Bokförla__737584FC11AC198E");

                entity.ToTable("Bokförlag");

                entity.Property(e => e.Namn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Land)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Butiker>(entity =>
            {
                entity.ToTable("Butiker");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gatuadress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Namn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ort)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Böcker>(entity =>
            {
                entity.HasKey(e => e.Isbn)
                    .HasName("PK__Böcker__447D36EB25975B31");

                entity.ToTable("Böcker");

                entity.Property(e => e.Isbn)
                    .ValueGeneratedNever()
                    .HasColumnName("ISBN");

                entity.Property(e => e.BokförlagNamn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bokförlag(Namn)");

                entity.Property(e => e.Pris).HasColumnType("money");

                entity.Property(e => e.Språk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Utgivningsdatum).HasColumnType("date");

                entity.HasOne(d => d.BokförlagNamnNavigation)
                    .WithMany(p => p.Böckers)
                    .HasForeignKey(d => d.BokförlagNamn)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Böcker__Bokförla__2B3F6F97");
            });

            modelBuilder.Entity<Dagsförsäljning>(entity =>
            {
                entity.HasKey(e => new { e.ButiksId, e.Datum })
                    .HasName("PK__Dagsförs__701907C0B9FC8BCC");

                entity.ToTable("Dagsförsäljning");

                entity.HasIndex(e => e.ButiksId, "PK, FK");

                entity.Property(e => e.ButiksId).HasColumnName("ButiksID");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Försäljning).HasColumnType("money");

                entity.HasOne(d => d.Butiks)
                    .WithMany(p => p.Dagsförsäljnings)
                    .HasForeignKey(d => d.ButiksId)
                    .HasConstraintName("FK__Dagsförsä__Butik__35BCFE0A");
            });

            modelBuilder.Entity<Författare>(entity =>
            {
                entity.ToTable("Författare");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Efternamn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Födelsedatum).HasColumnType("date");

                entity.Property(e => e.Förnamn)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FörfattareBöcker>(entity =>
            {
                entity.HasKey(e => new { e.Isbn, e.Id })
                    .HasName("PK__Författa__275C7829DE8C7CBB");

                entity.ToTable("Författare_Böcker");

                entity.HasIndex(e => e.Isbn, "PK, FK");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.FörfattareId).HasColumnName("FörfattareID");

                entity.HasOne(d => d.Författare)
                    .WithMany(p => p.FörfattareBöckers)
                    .HasForeignKey(d => d.FörfattareId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Författar__Förfa__3C69FB99");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.FörfattareBöckers)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Författare__ISBN__3D5E1FD2");
            });

            modelBuilder.Entity<FörsäljningsStatistik>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FörsäljningsStatistik");

                entity.Property(e => e.BästaDag).HasColumnType("money");

                entity.Property(e => e.Namn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotYtd)
                    .HasColumnType("money")
                    .HasColumnName("TotYTD");

                entity.Property(e => e.TotalFörsäljning).HasColumnType("money");

                entity.Property(e => e.TotföregåendeÅr)
                    .HasColumnType("money")
                    .HasColumnName("TOTFöregåendeÅr");

                entity.Property(e => e.TotmedelDagsFörsäljning)
                    .HasColumnType("money")
                    .HasColumnName("TOTMedelDagsFörsäljning");

                entity.Property(e => e.TotmedleFöregåendeÅr)
                    .HasColumnType("money")
                    .HasColumnName("TOTMedleFöregåendeÅr");
            });

            modelBuilder.Entity<Inköpsorder>(entity =>
            {
                entity.HasKey(e => new { e.Ordernummer, e.Isbn })
                    .HasName("PK__Inköpsor__4613DB21C04A7689");

                entity.ToTable("Inköpsorder");

                entity.HasIndex(e => e.Isbn, "PK, FK");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.ButiksId).HasColumnName("ButiksID");

                entity.Property(e => e.LeveransDatum).HasColumnType("date");

                entity.Property(e => e.PrisÁ)
                    .HasColumnType("money")
                    .HasColumnName("Pris á");

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
                    .HasName("PK__LagerSal__D6C358903121B2D5");

                entity.ToTable("LagerSaldo");

                entity.HasIndex(e => new { e.ButiksId, e.Isbn }, "PK, FK");

                entity.Property(e => e.Isbn).HasColumnName("ISBN");

                entity.Property(e => e.ButiksId).HasColumnName("ButiksID");

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
                    .HasName("PK__Personal__A6FF8FFF213C3B95");

                entity.ToTable("Personal");

                entity.Property(e => e.ArbetsplatsButiksId).HasColumnName("Arbetsplats(ButiksID)");

                entity.Property(e => e.Efternamn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Födelsedatum).HasColumnType("date");

                entity.Property(e => e.Förnamn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ArbetsplatsButiks)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.ArbetsplatsButiksId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Personal__Arbets__38996AB5");
            });

            modelBuilder.Entity<TitlarPerFörfattare>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TitlarPerFörfattare");

                entity.Property(e => e.LagervärdeUtpris)
                    .HasColumnType("money")
                    .HasColumnName("Lagervärde(Utpris)");

                entity.Property(e => e.Namn)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
