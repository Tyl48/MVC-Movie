using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; // Thêm dòng này
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class AnimeWatchingController : Controller
{
    public IActionResult AnimeWatching()
    {
        return View();
    }
}