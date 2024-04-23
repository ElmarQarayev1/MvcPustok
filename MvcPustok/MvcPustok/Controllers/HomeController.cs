using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcPustok.Data;

namespace MvcPustok.Controllers;

public class HomeController : Controller
{

     AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var Sliders = _context.Sliders.OrderBy(x => x.Order).ToList();
       return View(Sliders);
    }
}

