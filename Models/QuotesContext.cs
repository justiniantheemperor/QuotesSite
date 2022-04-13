using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesSite.Models
{
    public partial class QuotesContext : DbContext
    { 
        public QuotesContext()
    {
    }

    public QuotesContext(DbContextOptions<QuotesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Quote> Quotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlite("Data Source = Quotes.sqlite");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Quote>(entity =>
        {
            entity.HasKey(e => e.QuoteId);

            entity.HasIndex(e => e.QuoteId)
                .IsUnique();

            entity.Property(e => e.QuoteId)
                .HasColumnName("QuoteID")
                .ValueGeneratedNever();

            entity.Property(e => e.Quote).IsRequired();

            entity.Property(e => e.Author).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }   
}

