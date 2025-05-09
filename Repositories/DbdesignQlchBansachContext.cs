using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Repositories.Entities;

namespace Repositories;

public partial class DbdesignQlchBansachContext : DbContext
{
    public DbdesignQlchBansachContext()
    {
    }

    public DbdesignQlchBansachContext(DbContextOptions<DbdesignQlchBansachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookCategory> BookCategories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Publisher> Publishers { get; set; }

    public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }

    public virtual DbSet<PurchaseInvoiceDetail> PurchaseInvoiceDetails { get; set; }

    public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }

    public virtual DbSet<SalesInvoiceDetail> SalesInvoiceDetails { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);Database=DBDESIGN_QLCH_BANSACH;UID=sa;PWD=KIEN2005;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId).HasName("PK__Author__70DAFC34D0A8DC6C");

            entity.ToTable("Author");

            entity.Property(e => e.AuthorId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.AuthorName).HasMaxLength(100);
            entity.Property(e => e.BirthOfDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(10);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Books__3DE0C207218AAB4F");

            entity.Property(e => e.BookId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AuthorId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("TG001")
                .IsFixedLength();
            entity.Property(e => e.BookCategoryId).HasDefaultValue(1);
            entity.Property(e => e.BookName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.PublicationDate).HasColumnType("datetime");
            entity.Property(e => e.PublisherId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("NXB01")
                .IsFixedLength();

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Author");

            entity.HasOne(d => d.BookCategory).WithMany(p => p.Books)
                .HasForeignKey(d => d.BookCategoryId)
                .HasConstraintName("FK_BookCategory");

            entity.HasOne(d => d.Publisher).WithMany(p => p.Books)
                .HasForeignKey(d => d.PublisherId)
                .HasConstraintName("FK_Publisher");
        });

        modelBuilder.Entity<BookCategory>(entity =>
        {
            entity.HasKey(e => e.BookCategoryId).HasName("PK__BookCate__6347EC041A81A836");

            entity.ToTable("BookCategory");

            entity.Property(e => e.BookCategoryId).ValueGeneratedNever();
            entity.Property(e => e.BookGenreType).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D817907BFC");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04F11CA42F2A9");

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("00000")
                .IsFixedLength();
            entity.Property(e => e.EmployeeName).HasMaxLength(100);
        });

        modelBuilder.Entity<Publisher>(entity =>
        {
            entity.HasKey(e => e.PublisherId).HasName("PK__Publishe__4C657FAB07BD97EE");

            entity.ToTable("Publisher");

            entity.Property(e => e.PublisherId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PublisherAddress).HasMaxLength(255);
            entity.Property(e => e.PublisherName).HasMaxLength(100);
        });

        modelBuilder.Entity<PurchaseInvoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PK__Purchase__D796AAD5DB6EE744");

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KH001")
                .IsFixedLength();
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);
            entity.Property(e => e.SupplierId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("NCC01")
                .IsFixedLength()
                .HasColumnName("SupplierID");

            entity.HasOne(d => d.Employee).WithMany(p => p.PurchaseInvoices)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_PurchaseInvoices1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseInvoices)
                .HasForeignKey(d => d.SupplierId)
                .HasConstraintName("FK_PurchaseInvoices");
        });

        modelBuilder.Entity<PurchaseInvoiceDetail>(entity =>
        {
            entity.HasKey(e => new { e.InvoiceId, e.BookId });

            entity.ToTable(tb => tb.HasTrigger("trg_UpdateBookQuantityAfterInsert"));

            entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");
            entity.Property(e => e.BookId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BookID");

            entity.HasOne(d => d.Book).WithMany(p => p.PurchaseInvoiceDetails)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_PurchaseInvoiceDetails2");

            entity.HasOne(d => d.Invoice).WithMany(p => p.PurchaseInvoiceDetails)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_PurchaseInvoiceDetails");
        });

        modelBuilder.Entity<SalesInvoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PK__SalesInv__D796AAB5CE0EF34D");

            entity.ToTable("SalesInvoice");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KH000")
                .IsFixedLength();
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KH001")
                .IsFixedLength();
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.Note).HasMaxLength(200);

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesInvoices)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_SalesInvoice");

            entity.HasOne(d => d.Employee).WithMany(p => p.SalesInvoices)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_SalesInvoice1");
        });

        modelBuilder.Entity<SalesInvoiceDetail>(entity =>
        {
            entity.HasKey(e => new { e.InvoiceId, e.BookId });

            entity.ToTable("SalesInvoiceDetail", tb => tb.HasTrigger("trg_CheckStock_AndInsert"));

            entity.Property(e => e.BookId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Book).WithMany(p => p.SalesInvoiceDetails)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("FK_SalesInvoiceDetail_Book");

            entity.HasOne(d => d.Invoice).WithMany(p => p.SalesInvoiceDetails)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_SalesInvoiceDetail_Invoice");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE666942828EB14");

            entity.Property(e => e.SupplierId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SupplierID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SupplierName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__UserAcco__0CF04B18E77175E9");

            entity.ToTable("UserAccount");

            entity.Property(e => e.MemberId).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("NV001")
                .IsFixedLength();
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.Employee).WithMany(p => p.UserAccounts)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_UserAccount");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
