using System.Diagnostics.Contracts;
using FoodOrderingWebApp.Models;

namespace FoodOrderingWebApp.Data;

public class AppDbInitializer
{

    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

            context.Database.EnsureCreated();

            if (!context.Items.Any()) //if there are not any items in the db
            {
                context.Items.AddRange(new List<Item>()
                {
                    new Item()
                    {
                        ImageURL = "https://i.imgur.com/dxoPhw5.jpeg",
                        Name = "Beef Burger",
                        Description = "Yummy burger with beef patty and lots of love",
                        Ingredients = "beef patty,onions,salad,honey bun",
                        Price = 5,
                        ItemTypeId = 1,
                        RestaurantId = 1
                    }
                });
                
                context.SaveChanges();
            }

            if (!context.Offers.Any())
            {


                context.Offers.AddRange(new List<Offer>()
                {
                    new Offer()
                    {
                        StartDate = new DateTime(2023, 4, 12),
                        EndDate = new DateTime(2023, 4, 25),
                        Description = "For every 2 burgers bought you will get another one for free",
                        ImageURL = ""
                    }
                });
                
                context.SaveChanges();
            }


            if (!context.Restaurants.Any()) 
            {
                context.Restaurants.AddRange(new List<Restaurant>()
                {
                    new Restaurant()
                    {
                        LogoURL = "https://i.imgur.com/bQInPc5.png",
                        Name = "BurgerKing"
                    }
                });
                
                context.SaveChanges();
            }
            
            if (!context.ItemTypes.Any())
            {
                context.ItemTypes.AddRange(new List<ItemType>()
                {
                    new ItemType()
                    {
                        ImageURL = "https://i.imgur.com/dxoPhw5.jpeg",
                        Name = "Burgers"
                    }
                });

                context.SaveChanges();
            }
            
            if (!context.Offer_Restaurants.Any()) 
            {
                context.Offer_Restaurants.AddRange(new List<Offer_Restaurant>()
                {
                    new Offer_Restaurant(){
                        OfferId = 1,
                        RestaurantId = 1
                    }
                });
                context.SaveChanges();
            }
            
            if (!context.ItemType_Restaurants.Any()) 
            {
                context.ItemType_Restaurants.AddRange(new List<ItemType_Restaurant>()
                {
                    new ItemType_Restaurant(){
                        ItemTypeId = 1,
                        RestaurantId = 1,
                        
                    }
                });
                context.SaveChanges();
            }
            
        }
    }
}