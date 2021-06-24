using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        { }
        #region DbSet
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<EmployeeAuthorization> EmployeeAuthorizations { get; set; }
        public DbSet<AuthorTranslator> AuthorTranslators { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<BookView> BookViews { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<BannerSettings> BannerSettings { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderItems { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");
                entity.HasKey(e => e.Id);
                //Không tạo column trong db
                entity.Ignore(e => e.DisplayName);
                entity.Ignore(e => e.DisplayGender);

                entity.HasIndex(e => new{ e.Email, e.Username }).IsUnique(true);
                entity.Property(e => e.Name).IsRequired(true);
                entity.Property(e => e.Phone).IsRequired(true).HasMaxLength(11);
                entity.Property(e => e.Address).IsRequired(true);
                entity.Property(e => e.Position).IsRequired(true);
                entity.Property(e => e.Username).IsRequired(true);
                entity.Property(e => e.Password).IsRequired(true);
    });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");
                entity.HasKey(e => e.Id);
                //Không tạo column trong db
                entity.Ignore(e => e.DisplayName);
                entity.Ignore(e => e.DisplayGender);
                entity.HasIndex(e => new { e.Email, e.Username }).IsUnique(true);
                entity.Property(e => e.Name).IsRequired(true);
                entity.Property(e => e.Phone).IsRequired(true).HasMaxLength(11);
                entity.Property(e => e.Address).IsRequired(true);
                entity.Property(e => e.Username).IsRequired(true);
                entity.Property(e => e.Password).IsRequired(true);
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("Banner");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired(true);
                entity.Property(e => e.Image).IsRequired(true);
            });

            modelBuilder.Entity<EmployeeAuthorization>(entity =>
            {
                entity.ToTable("EmployeeAuthorization");
                entity.HasKey(e => e.EmployeeId);
                entity.Property(e => e.View).IsRequired(true).HasDefaultValue(0);
                entity.Property(e => e.Insert).IsRequired(true).HasDefaultValue(0);
                entity.Property(e => e.Update).IsRequired(true).HasDefaultValue(0);
                entity.Property(e => e.Delete).IsRequired(true).HasDefaultValue(0);

                entity.HasOne<Employee>(auth => auth.Employee)
                    .WithOne(emp => emp.EmployeeAuthorization)
                    .HasForeignKey<EmployeeAuthorization>(auth => auth.EmployeeId)
                    .HasConstraintName("FK_Authorization_Employee_EmployeeId");
            });

            modelBuilder.Entity<AuthorTranslator>(entity =>
            {
                entity.ToTable("AuthorTranslator");
                entity.HasKey(e => e.Id);
                entity.Ignore(e => e.DisplayName);
                entity.HasIndex(e => e.Slug).IsUnique(true);
                entity.Property(e => e.Author).IsRequired(true).HasDefaultValue(0);
                entity.Property(e => e.Translator).IsRequired(true).HasDefaultValue(0);
                entity.Property(e => e.Name).IsRequired(true).HasMaxLength(400);
                entity.Property(e => e.Slug).IsRequired(true);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
                entity.HasKey(e => e.Id);
                entity.Ignore(e => e.DisplayName);
                entity.HasIndex(e => e.Slug).IsUnique(true);
                entity.Property(e => e.Name).IsRequired(true).HasMaxLength(400);
                entity.Property(e => e.Slug).IsRequired(true);
                entity.Property(e => e.VerticalImage).IsRequired(true);
                entity.Property(e => e.HorizontalImage).IsRequired(true);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("Publisher");
                entity.HasKey(e => e.Id);
                entity.Ignore(e => e.DisplayName);
                entity.HasIndex(e => e.Slug).IsUnique(true);
                entity.Property(e => e.Name).IsRequired(true).HasMaxLength(400);
                entity.Property(e => e.Slug).IsRequired(true);
                entity.Property(e => e.Image).IsRequired(true);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");
                entity.HasKey(e => e.Id);
                //Không tạo column trong db
                entity.Ignore(e => e.DisplayName);
                entity.Ignore(e => e.DisplayPrice);
                entity.Ignore(e => e.PublicationDate);
                entity.Ignore(e => e.PrimaryImage);

                entity.HasIndex(e => e.Slug).IsUnique(true);
                entity.Property(e => e.Name).IsRequired(true).HasMaxLength(400);
                entity.Property(e => e.Slug).IsRequired(true);
                entity.Property(e => e.Description).IsRequired(true);
                entity.Property(e => e.CategoryId).IsRequired(true);
                entity.Property(e => e.PublisherId).IsRequired(true);
                entity.Property(e => e.AuthorId).IsRequired(true);

                entity.HasOne<Category>(b => b.Category)
                    .WithMany(c => c.Books)
                    .HasForeignKey(b => b.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Book_Category_CategoryId");

                entity.HasOne<Publisher>(b => b.Publisher)
                    .WithMany(p => p.Books)
                    .HasForeignKey(b => b.PublisherId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Book_Publisher_PublisherId");

                entity.HasOne<AuthorTranslator>(b => b.Author)
                    .WithMany(au => au.AuthorBooks)
                    .HasForeignKey(b => b.AuthorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Book_AuTrans_AuthorId");

                entity.HasOne<AuthorTranslator>(b => b.Translator)
                    .WithMany(t => t.TranslatorBooks)
                    .HasForeignKey(b => b.TranslatorId)
                    //.OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Book_AuTrans_TranslatorId");
            });

            modelBuilder.Entity<BookImage>(entity =>
            {
                entity.ToTable("BookImage");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.BookId).IsRequired(true);
                entity.Property(e => e.Image).IsRequired(true);
                entity.Property(e => e.Primary).HasDefaultValue(0);

                entity.HasOne<Book>(bi => bi.Book)
                    .WithMany(b => b.BookImages)
                    .HasForeignKey(bi => bi.BookId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BookImage_Book_BookId");
            });

            modelBuilder.Entity<BookView>(entity =>
            {
                entity.ToTable("BookView");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.BookId).IsRequired(true);
                entity.Property(e => e.SessionId).IsRequired(true);

                entity.HasOne<Book>(bv => bv.Book)
                    .WithMany(b => b.BookViews)
                    .HasForeignKey(bv => bv.BookId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BookView_Book_BookId");

                entity.HasOne<Customer>(bv => bv.Customer)
                    .WithMany(c => c.BookViews)
                    .HasForeignKey(bv => bv.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BookView_Customer_CustomerId");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Bought).IsRequired(true).HasDefaultValue(0);
                entity.Property(e => e.Name).IsRequired(true);
                entity.Property(e => e.BookId).IsRequired(true);
                entity.Property(e => e.Content).IsRequired(true);

                entity.HasOne<Book>(c => c.Book)
                    .WithMany(b => b.Comments)
                    .HasForeignKey(c => c.BookId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Comment_Book_BookId");

                entity.HasOne<Customer>(c => c.Customer)
                    .WithMany(cus => cus.Comments)
                    .HasForeignKey(c => c.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Comment_Customer_CustomerId");
            });

            modelBuilder.Entity<BannerSettings>(entity =>
            {
                entity.ToTable("BannerSettings");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired(true);
                entity.Property(e => e.Slug).IsRequired(true);
                entity.Property(e => e.Type).IsRequired(true);
                entity.Property(e => e.Image).IsRequired(true);
                entity.Property(e => e.Banner).HasDefaultValue(0);
                entity.Property(e => e.Category).HasDefaultValue(0);
                entity.Property(e => e.Coupon).HasDefaultValue(0);
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.ToTable("Wishlist");
                entity.HasKey(e => new { e.CustomerId, e.BookId });
                entity.Property(e => e.CustomerId).IsRequired(true);
                entity.Property(e => e.BookId).IsRequired(true);

                entity.HasOne<Book>(w => w.Book)
                    .WithMany(b => b.Wishlists)
                    .HasForeignKey(w => w.BookId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Wishlist_Book_BookId");

                entity.HasOne<Customer>(w => w.Customer)
                    .WithMany(cus => cus.Wishlists)
                    .HasForeignKey(w => w.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Wishlist_Customer_CustomerId");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired(true);
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.ToTable("PaymentMethod");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).IsRequired(true);
                entity.Property(e => e.IsSupported).HasDefaultValue(0);
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon");
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => new { e.Code, e.Slug }).IsUnique(true);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Code).IsRequired(true);
                entity.Property(e => e.Slug).IsRequired(true);
                entity.Property(e => e.Name).IsRequired(true);
                entity.Property(e => e.Description).IsRequired(true);
                entity.Property(e => e.Type).IsRequired(true);
                entity.Property(e => e.Image).IsRequired(true);

                entity.Property(e => e.Uses).HasDefaultValue(0);
                entity.Property(e => e.MaxUses).HasDefaultValue(0);
                entity.Property(e => e.MaxUsesUser).HasDefaultValue(0);
                entity.Property(e => e.MinPrice).HasDefaultValue(0);
                entity.Property(e => e.IsFixed).HasDefaultValue(0);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IsActive).HasDefaultValue(1);

                entity.HasOne<Customer>(c => c.Customer)
                    .WithOne(cus => cus.Cart)
                    .HasForeignKey<Cart>(c => c.CustomerId)
                    .HasConstraintName("FK_Cart_Customer_CustomerId");
            });

            modelBuilder.Entity<CartItems>(entity =>
            {
                entity.ToTable("CartItems");
                entity.HasKey(e => new { e.CartId, e.BookId });
                entity.Ignore(e => e.Total);
                entity.Ignore(e => e.DisplayTotal);

                entity.Property(e => e.BookId).IsRequired(true);

                entity.Property(e => e.IsSelected).HasDefaultValue(0);

                entity.HasOne<Cart>(ci => ci.Cart)
                    .WithMany(c => c.CartItems)
                    .HasForeignKey(ci => ci.CartId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CartItems_Cart_CartId");

                entity.HasOne<Book>(ci => ci.Book)
                    .WithMany(b => b.CartItems)
                    .HasForeignKey(ci => ci.BookId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CartItems_Book_BookId");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");
                entity.HasKey(e => e.Id);
                entity.Ignore(e => e.DisplayName);
                entity.Ignore(e => e.DisplaySubTotal);
                entity.Ignore(e => e.DisplayTotal);

                entity.Property(e => e.Name).IsRequired(true);
                entity.Property(e => e.Address).IsRequired(true);
                entity.Property(e => e.Phone).IsRequired(true).HasMaxLength(11);

                entity.Property(e => e.SubTotal).HasDefaultValue(0);
                entity.Property(e => e.Total).HasDefaultValue(0);
                entity.Property(e => e.StatusId).HasDefaultValue(1);
                entity.Property(e => e.PaymentMethodId).HasDefaultValue(1);
                entity.Property(e => e.PaymentStatus).HasDefaultValue(0);

                entity.HasOne<Customer>(o => o.Customer)
                    .WithMany(cus => cus.Orders)
                    .HasForeignKey(o => o.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Order_Customer_CustomerId");

                entity.HasOne<Coupon>(o => o.Coupon)
                    .WithMany(cp => cp.Orders)
                    .HasForeignKey(o => o.CouponId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Order_Coupon_CouponId");

                entity.HasOne<OrderStatus>(o => o.OrderStatus)
                    .WithMany(os => os.Orders)
                    .HasForeignKey(o => o.StatusId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Order_OrderStatus_StatusId");

                entity.HasOne<PaymentMethod>(o => o.PaymentMethod)
                    .WithMany(pm => pm.Orders)
                    .HasForeignKey(o => o.PaymentMethodId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Order_PaymentMethod_PaymentMethodId");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");
                entity.HasKey(e => new { e.OrderDetailId, e.OrderId });
                entity.Ignore(e => e.Total);
                entity.Ignore(e => e.DisplayPrice);
                entity.Ignore(e => e.DisplayTotal);

                entity.Property(e => e.OrderId).IsRequired(true);
                entity.Property(e => e.BookId).IsRequired(true);

                entity.HasOne<Order>(d => d.Order)
                    .WithMany(o => o.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_OrderDetail_Order_OrderId");

                entity.HasOne<Book>(d => d.Book)
                    .WithMany(b => b.OrderDetails)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_OrderDetail_Book_BookId");
            });

            //modelBuilder.Seed();
        }
    }
}
