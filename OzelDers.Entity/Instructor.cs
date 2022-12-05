using System;

namespace OzelDers.Entity
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public decimal OneHourPrice { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime DateAdded { get; set; }
        public string EmailAdres { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public ICollection<InstructorAndStudent> InstructorAndStudents { get; set; }

        public static implicit operator List<object>(Instructor v)
        {
            throw new NotImplementedException();
        }
    }
}

