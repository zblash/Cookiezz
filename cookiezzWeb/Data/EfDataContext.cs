﻿
using cookiezz.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cookiezz.Data
{
    public class EfDataContext : IdentityDbContext
    {
        public EfDataContext(DbContextOptions<EfDataContext> options)
        : base(options)
        {
        }
        public DbSet<User> Users {get; set;}
        public DbSet<Address> Addres { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
