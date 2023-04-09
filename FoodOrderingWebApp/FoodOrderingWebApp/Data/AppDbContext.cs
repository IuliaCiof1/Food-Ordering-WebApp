using FoodOrderingWebApp.Controllers;
using FoodOrderingWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebApp.Data;

public class AppDbContext:DbContext //translator between model classes and db
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //ItemType_Restaurant-ItemType-Restaurant
        //Create relationship many to many (one to many ItemType_Restaurant-ItemType and one to many ItemType_Restaurant-Restaurant)
        modelBuilder.Entity<ItemType_Restaurant>().HasKey(ir => new
        {
            ir.ItemTypeId, 
            ir.RestaurantId
        });
        
        modelBuilder.Entity<ItemType_Restaurant>().HasOne(x => x.ItemType).
            WithMany(x => x.ItemType_Restaurants).HasForeignKey(x => x.ItemTypeId);
        modelBuilder.Entity<ItemType_Restaurant>().HasOne(i => i.Restaurant).
            WithMany(x => x.ItemType_Restaurants).HasForeignKey(x => x.RestaurantId);
        
        
        base.OnModelCreating(modelBuilder);
        
        //Offer_Restaurant-Offer-Restaurant
        modelBuilder.Entity<Offer_Restaurant>().HasKey(ir => new
        {
            ir.OfferId, 
            ir.RestaurantId
        });
        
        modelBuilder.Entity<Offer_Restaurant>().HasOne(y => y.Offer).
            WithMany(y => y.Offer_Restaurants).HasForeignKey(y => y.OfferId);
        modelBuilder.Entity<Offer_Restaurant>().HasOne(y => y.Restaurant).
            WithMany(y => y.Offer_Restaurants).HasForeignKey(y => y.RestaurantId);
        
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<ItemType> ItemTypes { get; set;}
    public DbSet<ItemType_Restaurant> ItemType_Restaurants { get; set; }
    public DbSet<Offer> Offers { get; set; }
    public DbSet<Offer_Restaurant> Offer_Restaurants { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
}