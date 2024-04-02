using AspNetCore_MVC.Models.Components;
using AspNetCore_MVC.Models.Sections;
using AspNetCore_MVC.Models.Views;
using Infrastructures.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
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

            var response = await client.PostAsync("https://localhost:7023/api/Subscriber?key=44ee639f-12d8-4847-a560-0604cc38cd57", content);
            if (response.IsSuccessStatusCode)
            {
                TempData["Success"] = "Success";
            }
            else if (response.StatusCode == HttpStatusCode.Conflict)
            {
                TempData["Success"] = "Conflict";
            }
        }
        else
        {
            TempData["Success"] = "Invalid";
        }
        return RedirectToAction("Index", "Home", "newsletterId");
    }


    [Route("/unsubscribe")]
    public IActionResult Unsubscribe()
    {
        ViewData["Title"] = "Unsubscribe from newsletter.";
        return View();
    }

    [HttpPost]
    [Route("/unsubscribe")]
    public async Task<IActionResult> Unsubscribe(UnsubscribeModel model)
    {
        if (ModelState.IsValid)
        {
            using var client = new HttpClient();
            var response = await client.DeleteAsync($"https://localhost:7023/api/Subscriber?key=44ee639f-12d8-4847-a560-0604cc38cd57&email={model.Email}");

            if (response.IsSuccessStatusCode)
            {
                TempData["Unsubscribed"] = "Success";
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                TempData["Unsubscribed"] = "NotFound";
            }
            else
            {
                TempData["Unsubscribed"] = "Problem";
            }
        }

        else
        {
            TempData["Unsubscribed"] = "NotFound";
        }
        return View();
    }
}
