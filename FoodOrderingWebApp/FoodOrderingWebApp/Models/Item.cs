using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodOrderingWebApp.Models;

public class Item
{
    [Key] //data annotations
    public int Id { get; set; } //unique identifier for this class and table row from db, every mode has this
    
    [Display(Name = "item_imageUrl")]
    public string ImageURL { get; set; }
    
    [Display(Name = "item_name")]
    public string Name { get; set; }
    
    [Display(Name = "item_description")]
    public string Description { get; set; }
    
    [Display(Name = "item_ingredients")]
    public string Ingredients { get; set; }
    
    [Display(Name = "item_price")] 
    public double Price { get; set; }
    
    //Relationships
    //Item type
    public int ItemTypeId { get; set; } //this wil be the foreign key for type
    
    [ForeignKey("ItemTypeId")]
    public ItemType ItemType { get; set; }
    
    //Restaurant
    public int RestaurantId { get; set; }
    
    [ForeignKey("RestaurantId")]
    public Restaurant Restaurant { get; set; }
}