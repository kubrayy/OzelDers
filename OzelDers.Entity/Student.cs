using System;
namespace OzelDers.Entity
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public ICollection<InstructorAndStudent> InstructorAndStudents { get; set; }
    }
}

