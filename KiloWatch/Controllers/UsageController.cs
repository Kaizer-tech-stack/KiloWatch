
using Microsoft.AspNetCore.Mvc;

namespace KiloWatch.Controllers;

public class UsageController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Real-Time Usage";

        return View();
    }
}
