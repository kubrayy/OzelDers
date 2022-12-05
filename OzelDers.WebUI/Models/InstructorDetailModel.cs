using System;
using System.Collections.Generic;
using OzelDers.Entity;

namespace OzelDers.WebUI.Models
{
    public class InstructorDetailModel
    {
        public Instructor Instructor { get; set; } = null!;
        public List<Language> Languages { get; set; } = null!;
    }
}

