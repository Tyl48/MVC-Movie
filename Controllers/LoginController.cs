using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class LoginController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}