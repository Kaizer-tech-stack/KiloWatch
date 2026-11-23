using Microsoft.AspNetCore.Mvc;


namespace KiloWatch.Controllers;

public class BillingController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Billing & Rates";

        return View();
    }

}