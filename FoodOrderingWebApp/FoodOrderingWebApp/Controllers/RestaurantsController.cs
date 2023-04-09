using FoodOrderingWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebApp.Controllers;

public class RestaurantsController : Controller
{
    private readonly AppDbContext cotext;

    public RestaurantsController(AppDbContext context)
    {
        this.cotext = context;
    }
    
    // GET
    // public async Task<IActionResult> Index()
    // {
    //     var allOffers = await cotext.Restaurants.ToListAsync();
    //     
    //     return View();
    // }
}