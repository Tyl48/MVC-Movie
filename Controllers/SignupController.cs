namespace MvcMovie.Models;
using Microsoft.AspNetCore.Mvc; // Thêm dòng này
public class SignupController : Controller
{
    public IActionResult Signup()
    {
        return View();
    }
}