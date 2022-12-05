using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Data.Concrete;
using OzelDers.Business.Abstract;
using OzelDers.Entity;
using OzelDers.WebUI.Models;
using OzelDers.WebUI.ViewModels;

namespace OzelDers.WebUI.Controllers;

public class HomeController : Controller
{
    private readonly ILanguageService _languageService;
    public HomeController(ILanguageService languageService)
    {
        _languageService = languageService;
    }

    public IActionResult Index()
    {
        List<Language> languages = _languageService.GetAll();
        LanguageViewModel viewModel = new LanguageViewModel();
        viewModel.Languages = languages;
        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

