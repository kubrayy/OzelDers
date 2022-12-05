using System;
namespace OzelDers.Entity
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Instructor> Instructors { get; set; } = null!;
    }
}

