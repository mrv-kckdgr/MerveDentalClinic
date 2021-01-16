using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MerveDentalDental
{
    public partial class MerveDentalDentalContext : DbContext
    {
        public MerveDentalDentalContext()
        {
        }

        public MerveDentalDentalContext(DbContextOptions<MerveDentalDentalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ap00> Ap00 { get; set; }
        public virtual DbSet<Au00> Au00 { get; set; }
        public virtual DbSet<Cl00> Cl00 { get; set; }
        public virtual DbSet<Dr00> Dr00 { get; set; }
        public virtual DbSet<Dr01> Dr01 { get; set; }
        public virtual DbSet<Ds00> Ds00 { get; set; }
        public virtual DbSet<Ds01> Ds01 { get; set; }
        public virtual DbSet<Pt00> Pt00 { get; set; }
        public virtual DbSet<Pt01> Pt01 { get; set; }
        public virtual DbSet<Pt02> Pt02 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;User Id=root; port=3306; Database=MerveDentalDental");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ap00>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PRIMARY");

                entity.ToTable("ap00");

                entity.HasIndex(e => e.Drid)
                    .HasName("FK_AP00_DR00");

                entity.HasIndex(e => e.Pid)
                    .HasName("FK_AP00_PT00");

                entity.Property(e => e.Aid)
                    .HasColumnName("aid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Drid)
                    .HasColumnName("drid")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("varchar(11)");

                entity.HasOne(d => d.Dr)
                    .WithMany(p => p.Ap00)
                    .HasForeignKey(d => d.Drid)
                    .HasConstraintName("FK_AP00_DR00");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Ap00)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_AP00_PT00");
            });

            modelBuilder.Entity<Au00>(entity =>
            {
                entity.HasKey(e => e.Auid)
                    .HasName("PRIMARY");

                entity.ToTable("au00");

                entity.Property(e => e.Auid)
                    .HasColumnName("auid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Auname)
                    .HasColumnName("auname")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Cl00>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PRIMARY");

                entity.ToTable("cl00");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Caddress)
                    .HasColumnName("caddress")
                    .HasColumnType("longtext");

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Ctel)
                    .HasColumnName("ctel")
                    .HasColumnType("varchar(11)");
            });

            modelBuilder.Entity<Dr00>(entity =>
            {
                entity.HasKey(e => e.Drid)
                    .HasName("PRIMARY");

                entity.ToTable("dr00");

                entity.HasIndex(e => e.Auid)
                    .HasName("FK_DR00_AU00");

                entity.Property(e => e.Drid)
                    .HasColumnName("drid")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Auid)
                    .HasColumnName("auid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Drbranch)
                    .HasColumnName("drbranch")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Drname)
                    .HasColumnName("drname")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Drsurname)
                    .HasColumnName("drsurname")
                    .HasColumnType("varchar(15)");

                entity.HasOne(d => d.Au)
                    .WithMany(p => p.Dr00)
                    .HasForeignKey(d => d.Auid)
                    .HasConstraintName("FK_DR00_AU00");
            });

            modelBuilder.Entity<Dr01>(entity =>
            {
                entity.HasKey(e => e.Cdrid)
                    .HasName("PRIMARY");

                entity.ToTable("dr01");

                entity.HasIndex(e => e.Cid)
                    .HasName("FK_DR01_CL00");

                entity.HasIndex(e => e.Drid)
                    .HasName("FK_DR01_DR00");

                entity.Property(e => e.Cdrid)
                    .HasColumnName("cdrid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Drid)
                    .HasColumnName("drid")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Finishdate)
                    .HasColumnName("finishdate")
                    .HasColumnType("date");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.C)
                    .WithMany(p => p.Dr01)
                    .HasForeignKey(d => d.Cid)
                    .HasConstraintName("FK_DR01_CL00");

                entity.HasOne(d => d.Dr)
                    .WithMany(p => p.Dr01)
                    .HasForeignKey(d => d.Drid)
                    .HasConstraintName("FK_DR01_DR00");
            });

            modelBuilder.Entity<Ds00>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PRIMARY");

                entity.ToTable("ds00");

                entity.Property(e => e.Did)
                    .HasColumnName("did")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dname)
                    .HasColumnName("dname")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Dstate)
                    .HasColumnName("dstate")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.IsAbout)
                    .HasColumnName("is_about")
                    .HasColumnType("tinyint(1)");
            });

            modelBuilder.Entity<Ds01>(entity =>
            {
                entity.HasKey(e => e.DsPtId)
                    .HasName("PRIMARY");

                entity.ToTable("ds01");

                entity.Property(e => e.DsPtId)
                    .HasColumnName("ds_pt_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Did)
                    .HasColumnName("did")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Pt00>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PRIMARY");

                entity.ToTable("pt00");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Psurname)
                    .HasColumnName("psurname")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Pt01>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PRIMARY");

                entity.ToTable("pt01");

                entity.HasIndex(e => e.Drid)
                    .HasName("FK_PT01_DR00");

                entity.HasIndex(e => e.Pid)
                    .HasName("FK_PT01_PT00");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Decision)
                    .HasColumnName("decision")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Drid)
                    .HasColumnName("drid")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("varchar(11)");

                entity.HasOne(d => d.Dr)
                    .WithMany(p => p.Pt01)
                    .HasForeignKey(d => d.Drid)
                    .HasConstraintName("FK_PT01_DR00");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Pt01)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_PT01_PT00");
            });

            modelBuilder.Entity<Pt02>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PRIMARY");

                entity.ToTable("pt02");

                entity.HasIndex(e => e.Drid)
                    .HasName("FK_PTDR02_Treatment_DR00_Doctor");

                entity.HasIndex(e => e.Pid)
                    .HasName("FK_PTDR02_Treatment_PT00_Patient");

                entity.Property(e => e.Tid)
                    .HasColumnName("tid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Drid)
                    .HasColumnName("drid")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("varchar(11)");

                entity.Property(e => e.Tdate)
                    .HasColumnName("tdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tname)
                    .HasColumnName("tname")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.Tsession)
                    .HasColumnName("tsession")
                    .HasColumnType("varchar(15)");

                entity.HasOne(d => d.Dr)
                    .WithMany(p => p.Pt02)
                    .HasForeignKey(d => d.Drid)
                    .HasConstraintName("FK_PTDR02_Treatment_DR00_Doctor");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Pt02)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_PTDR02_Treatment_PT00_Patient");
            });
        }
    }
}
