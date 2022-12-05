using System;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;

namespace OzelDers.WebUI.Controllers
{
    public class LanguageController : Controller
    {
        private ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        public IActionResult Index()
        {
            var languages = _languageService.GetAll();
            return View(languages);
        }
    }
}

