using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OzelDers.Business.Abstract;
using OzelDers.Business.Concrete;
using OzelDers.Entity;
using OzelDers.WebUI.Models;
using OzelDers.WebUI.ViewModels;

namespace OzelDers.WebUI.Controllers
{
    public class OzelDersController : Controller
    {
        private IInstructorService _instructorService;

        public OzelDersController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HowItWorks()
        {
            return View();
        }

        public IActionResult List(string language, int page=1)
        {
            const int pageSize = 3;
            List<Instructor> instructors = _instructorService.GetInstructorsByLanguage(language,page,pageSize);

            PageInfo pageInfo = new PageInfo()
            {
                TotalItems = _instructorService.GetCountByLanguage(language),
                CurrentPage = page,
                ItemsPerPage = pageSize,
                CurrentLanguage = language
            };

            InstructorViewModel instructorViewModel = new InstructorViewModel()
            {
                Instructors = instructors,
                PageInfo = pageInfo
            };
            return View(instructorViewModel);
        }

        public IActionResult Details(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return NotFound();
            }
            Instructor instructor = _instructorService.GetInstructorDetails(url);
            InstructorDetailModel instructorDetailModel = new InstructorDetailModel()
            {
                Instructor = instructor,
            };
            return View(instructorDetailModel);
        }

        public IActionResult Search(string q)
        {
            List<Instructor> searchResult = _instructorService.GetSearchResult(q);
            return View(searchResult);
        }
    }
}

