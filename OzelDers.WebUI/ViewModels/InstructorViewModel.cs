using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;
using OzelDers.Entity;

namespace OzelDers.WebUI.ViewModels
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string? CurrentLanguage { get; set; }
        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }
    public class InstructorViewModel
    {
        public PageInfo PageInfo { get; set; } = null!;
        public List<Instructor> Instructors { get; set; } = null!;
    }
}

