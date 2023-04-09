using System.ComponentModel.DataAnnotations;

namespace FoodOrderingWebApp.Models;

public class Restaurant
{
    [Key]
    public int Id { get; set; }
    
    public string LogoURL { get; set; }
    public string Name { get; set; }

    private struct Location
    {
        public string city;
        public string street;
        public int num;
    }

    public void SetLocation(string city, string street, int num)
    {
        Location loc;
        loc.city = city;
        loc.street = street;
        loc.num = num;
    }
    
    //Relationships
    //ItemTypes
    public  List<ItemType_Restaurant> ItemType_Restaurants { get; set; }

    //Offers
    public  List<Offer_Restaurant> Offer_Restaurants { get; set; }
}