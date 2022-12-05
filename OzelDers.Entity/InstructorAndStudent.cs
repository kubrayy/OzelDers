using System;
namespace OzelDers.Entity
{
    public class InstructorAndStudent
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
    }
}

