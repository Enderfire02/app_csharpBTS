using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace app_csharpBTS.Models
{
    public partial class projetcsharpContext : DbContext
    {
        public projetcsharpContext()
        {
        }

        public projetcsharpContext(DbContextOptions<projetcsharpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Decoclass> Decoclasses { get; set; }
        public virtual DbSet<Organize> Organizes { get; set; }
        public virtual DbSet<Partake> Partakes { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=projetcsharp;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("latin1")
                .UseCollation("latin1_swedish_ci");

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdCli)
                    .HasName("PRIMARY");

                entity.ToTable("client");

                entity.Property(e => e.IdCli)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Cli");

                entity.Property(e => e.EmailCli)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Email_Cli");

                entity.Property(e => e.FirstnameCli)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Firstname_Cli");

                entity.Property(e => e.NameCli)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Name_Cli");
            });

            modelBuilder.Entity<Decoclass>(entity =>
            {
                entity.HasKey(e => e.IdClass)
                    .HasName("PRIMARY");

                entity.ToTable("decoclass");

                entity.HasIndex(e => e.IdStaff, "Class_Staff_AK")
                    .IsUnique();

                entity.Property(e => e.IdClass)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Class");

                entity.Property(e => e.IdStaff)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Staff");

                entity.Property(e => e.NameClass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Name_Class");

                entity.Property(e => e.PlaceClass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Place_Class");

                entity.HasOne(d => d.IdStaffNavigation)
                    .WithOne(p => p.Decoclass)
                    .HasForeignKey<Decoclass>(d => d.IdStaff)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Class_Staff_FK");
            });

            modelBuilder.Entity<Organize>(entity =>
            {
                entity.HasKey(e => new { e.IdProduct, e.IdStaff })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("organize");

                entity.HasIndex(e => e.IdStaff, "Organize_Staff0_FK");

                entity.Property(e => e.IdProduct)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Product");

                entity.Property(e => e.IdStaff)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Staff");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Organizes)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Organize_Product_FK");

                entity.HasOne(d => d.IdStaffNavigation)
                    .WithMany(p => p.Organizes)
                    .HasForeignKey(d => d.IdStaff)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Organize_Staff0_FK");
            });

            modelBuilder.Entity<Partake>(entity =>
            {
                entity.HasKey(e => new { e.IdClass, e.IdCli })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("partake");

                entity.HasIndex(e => e.IdCli, "Partake_Client0_FK");

                entity.Property(e => e.IdClass)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Class");

                entity.Property(e => e.IdCli)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Cli");

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.Partakes)
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Partake_Class_FK");

                entity.HasOne(d => d.IdCliNavigation)
                    .WithMany(p => p.Partakes)
                    .HasForeignKey(d => d.IdCli)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Partake_Client0_FK");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("PRIMARY");

                entity.ToTable("product");

                entity.Property(e => e.IdProduct)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Product");

                entity.Property(e => e.NameProduct)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Name_Product");

                entity.Property(e => e.PriceProduct)
                    .HasColumnType("int(11)")
                    .HasColumnName("Price_Product");

                entity.Property(e => e.StockProduct)
                    .HasColumnType("int(11)")
                    .HasColumnName("Stock_Product");

                entity.Property(e => e.TypeProduct)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("Type_Product");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasKey(e => e.IdStaff)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdStaff)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID_Staff");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
