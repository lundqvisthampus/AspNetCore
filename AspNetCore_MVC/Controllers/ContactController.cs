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

            var response = await http.PostAsync("https://localhost:7023/api/Contact?key=44ee639f-12d8-4847-a560-0604cc38cd57", content);

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
