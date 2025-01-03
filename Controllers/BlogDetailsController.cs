using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; // Thêm dòng này
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class BlogDetailsController : Controller
{
    public IActionResult BlogDetails()
    {
        return View();
    }
}