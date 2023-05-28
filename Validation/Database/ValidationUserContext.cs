using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Validation.Models;

namespace Validation.Database;

public partial class ValidationUserContext : DbContext
{
    public ValidationUserContext()
    {
    }

    public ValidationUserContext(DbContextOptions<ValidationUserContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server = PAWOK; Database = ValidationUser; Trusted_Connection = true; TrustServerCertificate = true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.Username, "IX_User").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(40);
            entity.Property(e => e.Username).HasMaxLength(40);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
