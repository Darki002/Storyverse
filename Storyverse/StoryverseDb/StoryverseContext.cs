using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StoryverseDb.Modul;

namespace StoryverseDb;

public partial class StoryverseContext : DbContext
{
    public virtual DbSet<Story> Stories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=StoryverseDB;User ID=sa;Password=lksdjfghg//879453/fdhsiuj; TrustServerCertificate=Yes;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Story>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__story__3214EC273BA75EB0");

            entity.ToTable("story");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Content)
                .IsUnicode(false)
                .HasColumnName("content");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
