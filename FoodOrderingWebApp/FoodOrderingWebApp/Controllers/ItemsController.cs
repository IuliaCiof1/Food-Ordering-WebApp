using FoodOrderingWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrderingWebApp.Controllers;

public class ItemsController : Controller
{
    private readonly AppDbContext context;

    public ItemsController(AppDbContext context)
    {
        this.context = context;
    }
    
    // GET
    public IActionResult Index()
    {
        var allItems = context.Items.ToList();
        
        return View(allItems);
    }
}