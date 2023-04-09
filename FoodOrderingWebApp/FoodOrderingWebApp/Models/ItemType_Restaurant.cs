namespace FoodOrderingWebApp.Models;

public class ItemType_Restaurant
{
    public int ItemTypeId { get; set; }
    public ItemType ItemType { get; set; }
    
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get;  set; }
}