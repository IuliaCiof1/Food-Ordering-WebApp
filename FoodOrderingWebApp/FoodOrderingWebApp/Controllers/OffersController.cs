using FoodOrderingWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebApp.Controllers;

public class OffersController : Controller
{
    private readonly AppDbContext cotext;

    public OffersController(AppDbContext context)
    {
        this.cotext = context;
    }
    
    // GET
    // public async Task<IActionResult> Index()
    // {
    //     var allOffers = await cotext.Offers.ToListAsync();
    //     
    //     return View();
    // }
}