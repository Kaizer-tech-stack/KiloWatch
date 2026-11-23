using Microsoft.AspNetCore.Mvc;


namespace KiloWatch.Controllers;

public class ApplianceController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Appliance Audit";
        return View();
    }
}