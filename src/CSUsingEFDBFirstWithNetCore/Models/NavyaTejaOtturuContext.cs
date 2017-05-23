using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSUsingEFDBFirstWithNetCore
{
    public partial class NavyaTejaOtturuContext : DbContext
    {
        public static string ConnectionString=null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Details>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Details__CA1EE06C9E336B42");

                entity.Property(e => e.Sno)
                    .HasColumnName("SNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }

        public virtual DbSet<Details> Details { get; set; }
    }
}