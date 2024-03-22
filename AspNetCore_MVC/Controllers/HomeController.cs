using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;
using AspNetCore_MVC.Models.Views;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace AspNetCore_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var viewModel = new HomeIndexViewModel();

        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

    [Route("/error")]
    public IActionResult Error()
    {
        ViewData["Title"] = "Error";
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Subscribe(HomeIndexViewModel viewModel)
    {
        ViewData["Title"] = viewModel.Title;

        if (ModelState.IsValid)
        {
            using var client = new HttpClient();

            var json = JsonConvert.SerializeObject(viewModel.Subscribe);
            using var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:7023/api/Subscriber", content);
            if (response.IsSuccessStatusCode)
            {
                ViewData["Subscribed"] = true;
            }
        }

        return RedirectToAction("Index");
    }
}
