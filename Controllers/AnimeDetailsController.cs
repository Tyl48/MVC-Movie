using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; // Thêm dòng này
using MvcMovie.Models;

namespace MvcMovie.Controllers;


public class AnimeDetailsController : Controller
{
    public IActionResult AnimeDetails()
    {
        return View();
    }

}