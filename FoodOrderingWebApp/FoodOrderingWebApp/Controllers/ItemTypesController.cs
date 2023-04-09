using FoodOrderingWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderingWebApp.Controllers;

public class ItemTypesController : Controller
{
    private readonly AppDbContext cotext;

    public ItemTypesController(AppDbContext context)
    {
        this.cotext = context;
    }
    
    // GET
    // public IActionResult Index() //synchronous method
    // {
    //     var data = cotext.ItemTypes.ToList();
    //     return View();
    // }
    
    // public async Task<IActionResult> Index() //synchronous method
    // {
    //     var allItemTypes = await cotext.ItemTypes.ToListAsync();
    //     return View();
    // }
}