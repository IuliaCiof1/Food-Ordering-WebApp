using System.ComponentModel.DataAnnotations;

namespace FoodOrderingWebApp.Models;

public class Offer
{
    [Key]
    public int Id { get; set; }
    
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }

    //Relationships
    //Restaurants
    //public int RestaurantId { get; set; }
    
    //[ForeignKey("RestaurantId")]
    public List<Offer_Restaurant> Offer_Restaurants { get; set; }
}