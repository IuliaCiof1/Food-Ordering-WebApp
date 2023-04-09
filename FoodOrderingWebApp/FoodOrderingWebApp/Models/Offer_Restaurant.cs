namespace FoodOrderingWebApp.Models;

public class Offer_Restaurant
{
    public int OfferId { get; set; }
    public Offer Offer { get; set; }

    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
}