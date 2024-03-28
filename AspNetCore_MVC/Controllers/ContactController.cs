using AspNetCore_MVC.Models;
using Infrastructures.Dto;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_MVC.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Contact Us";
        return View();
    }

    [HttpPost]
    public IActionResult Index(ContactDto dto)
    {
        ViewData["Title"] = "Contact Us";

        if (ModelState.IsValid)
        {
            ViewData["MessageSent"] = "True";
            return View();
        }
        ViewData["MessageSent"] = "False";
        return View();
    }
}
