using AspNetCore_MVC.Models;
using Infrastructures.Dto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AspNetCore_MVC.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Contact Us";
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(ContactDto dto)
    {
        ViewData["Title"] = "Contact Us";

        if (ModelState.IsValid)
        {
            using var http = new HttpClient();
            var json = JsonConvert.SerializeObject(dto);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            var response = await http.PostAsync("https://localhost:7023/api/Contact", content);

            if (response.IsSuccessStatusCode)
            {
                ViewData["MessageSent"] = "True";
            }
            else
            {
                ViewData["MessageSent"] = "False";
            }
        }
        else
        {
            ViewData["MessageSent"] = "BadRequest";
        }
        return View();
    }
}
