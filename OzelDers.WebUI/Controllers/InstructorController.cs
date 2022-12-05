using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OzelDers.Business.Abstract;
using OzelDers.Entity;
using OzelDers.WebUI.ViewModels;

namespace OzelDers.WebUI.Controllers;

public class InstructorController : Controller
{
    private readonly ILogger<InstructorController> _logger;
    private IInstructorService _instructorService;
    public InstructorController(ILogger<InstructorController> logger, IInstructorService instructorService)
    {
        _logger = logger;
        _instructorService = instructorService;
    }
    public IActionResult Index()
    {
        List<Instructor> instructors = _instructorService.GetAll();
        InstructorViewModel viewModel = new InstructorViewModel();
        viewModel.Instructors = instructors;
        return View(viewModel);
    }
}

