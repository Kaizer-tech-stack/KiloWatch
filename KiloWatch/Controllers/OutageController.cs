using Microsoft.AspNetCore.Mvc;

namespace KiloWatch.Controllers;

public class OutageController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Outage Advisories";
        return View();
    }
}