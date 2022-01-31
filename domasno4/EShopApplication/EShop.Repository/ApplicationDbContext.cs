using EShop.Domain.DomainModels;
using EShop.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EShop.Repository
{
    public class ApplicationDbContext:IdentityDbContext<EShopApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {   
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ProductInShoppingCart> ProductInShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>()
                .Property(r => r.Id)
                .ValueGeneratedOnAdd();
            builder.Entity<ShoppingCart>()
                .Property(r => r.Id)
                .ValueGeneratedOnAdd();
            builder.Entity<ProductInShoppingCart>()
                .HasKey(r => new { r.ProductId, r.ShoppingCartId });
            builder.Entity<ProductInShoppingCart>()
                .HasOne(r => r.Product)
                .WithMany(r => r.ProductInShoppingCarts)
                .HasForeignKey(r => r.ShoppingCartId);
            builder.Entity<ProductInShoppingCart>()
                .HasOne(r => r.ShoppingCart)
                .WithMany(r => r.ProductInShoppingCarts)
                .HasForeignKey(r => r.ProductId);
            builder.Entity<ShoppingCart>()
                .HasOne<EShopApplicationUser>(r => r.Owner)
                .WithOne(r => r.UserCart)
                .HasForeignKey<ShoppingCart>(r => r.OwnerId);
            builder.Entity<ProductInOrder>()
                .HasKey(r => new { r.ProductId, r.OrderId });
            builder.Entity<ProductInOrder>()
                .HasOne(r => r.SelectedProduct)
                .WithMany(r => r.Orders)
                .HasForeignKey(r => r.ProductId);
            builder.Entity<ProductInOrder>()
                .HasOne(r => r.UserOrder)
                .WithMany(r => r.Products)
                .HasForeignKey(r => r.OrderId);
        }
    }
}
