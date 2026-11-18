
using Microsoft.AspNetCore.Mvc;

namespace KiloWatch.Controllers;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Overview";
        return View();
    }
}
