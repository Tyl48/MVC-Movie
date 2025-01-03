using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; // Thêm dòng này
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class BlogController : Controller
{
    public IActionResult Blog()
    {
        return View();
    }
}