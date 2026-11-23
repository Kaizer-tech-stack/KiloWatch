using Microsoft.AspNetCore.Mvc;

namespace KiloWatch.Controllers;

public class SolarController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Solar & Net Metering";
        return View();
    }
}