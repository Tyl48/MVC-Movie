using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; // Thêm dòng này
using MvcMovie.Models;

namespace MovieProjectNET.Controllers;

public class CategoriesController : Controller
{
    public IActionResult Categories() // Sửa IActionsResult thành IActionResult
    {
        return View();
    }
}