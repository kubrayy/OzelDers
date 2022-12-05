using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Business.Concrete;
using OzelDers.Entity;

namespace OzelDers.WebUI.Components
{
    public class LanguagesViewComponent : ViewComponent
    {
        private ILanguageService _languageService;

        public LanguagesViewComponent(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["language"] != null)
            {
                ViewBag.SelectedLanguage = RouteData.Values["language"];
            }

            List<Language> languages = _languageService.GetAll();
            return View(languages);
        }
    }
}

