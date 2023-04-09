using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderingWebApp.Models;

public class ItemType
{
    [Key] //data annotations
    public int Id { get; set; } //unique identifier for this class and table row from db, every mode has this
    
    public string ImageURL { get; set; }
    public string Name { get; set; }
    
    //Relationships
    //Items
    // public int ItemId;
    //
    // [ForeignKey("ItemId")]
    public List<Item> Items { get; set; }
    
    //Restaurants
    public  List<ItemType_Restaurant> ItemType_Restaurants { get; set; }
}