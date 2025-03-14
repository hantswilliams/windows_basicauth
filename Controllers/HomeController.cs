using Microsoft.AspNetCore.Mvc;

namespace windows_basicauth.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}