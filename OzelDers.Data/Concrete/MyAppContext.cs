using System;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using OzelDers.Entity;

namespace OzelDers.Data.Concrete
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<InstructorAndStudent> InstructorAndStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<InstructorAndStudent>()
                .HasKey(c => new
                {
                    c.InstructorId,
                    c.StudentId
                });
            modelBuilder
                .Entity<Student>()
                .HasData(
                new Student() { Id = 1, Name = "Joseph", LastName = "Purple", Age = 17 },
                new Student() { Id = 2, Name = "Yusuf", LastName = "Black", Age = 16 },
                new Student() { Id = 3, Name = "Merve", LastName = "Pink", Age = 26 },
                new Student() { Id = 4, Name = "Aslı", LastName = "Maslı", Age = 37 });

            modelBuilder
                .Entity<Instructor>()
                .HasData(
                new Instructor() { Id = 1, Name = "Rose", LastName = "Black", Description = "Hello, I'm English. Let's make practice!", Url = "1", ImageUrl = "1_en.jpeg", OneHourPrice = 50, Gender = "Woman", Age = 77, DateAdded = DateTime.Now , LanguageId = 1 , EmailAdres= "roseblack@example.com" },
                new Instructor() { Id = 2, Name = "Charles", LastName = "Prince", Description = "Hello, I'm English. Let's make practice!", Url = "2", ImageUrl = "2_en.jpeg", OneHourPrice = 70, Gender = "Man", Age = 65, DateAdded = DateTime.Now , LanguageId = 1 , EmailAdres= "charlesprince@example.com" },
                new Instructor() { Id = 3, Name = "Elizabeth", LastName = "Blue", Description = "Hello, I'm English. Let's make practice!", Url = "3", ImageUrl = "3_en.jpeg", OneHourPrice = 50, Gender = "Man", Age = 35, DateAdded = DateTime.Now , LanguageId = 1 , EmailAdres= "elizabethblue@example.com" },
                new Instructor() { Id = 4, Name = "Blas", LastName = "Köln", Description = "Hello, I'm German. Let's make practice!", Url = "4", ImageUrl = "4_alm.jpeg", OneHourPrice = 90, Gender = "Man", Age = 34, DateAdded = DateTime.Now , LanguageId = 2 , EmailAdres= "blaskoln@example.com" },
                new Instructor() { Id = 5, Name = "Odiane", LastName = "Modiane", Description = "Hello, I'm German. Let's make practice!", Url = "5", ImageUrl = "5_alm.jpeg", OneHourPrice = 120, Gender = "Man", Age = 46, DateAdded = DateTime.Now , LanguageId = 2 , EmailAdres= "odianemodiane@example.com" },
                new Instructor() { Id = 6, Name = "Trudy", LastName = "Mrudy", Description = "Hello, I'm German. Let's make practice!", Url = "6", ImageUrl = "6_alm.jpeg", OneHourPrice = 150, Gender = "Man", Age = 34, DateAdded = DateTime.Now , LanguageId = 2 , EmailAdres= "trudymrudy@example.com" },
                new Instructor() { Id = 7, Name = "Alessa", LastName = "Malessa", Description = "Hello, I'm Italian. Let's make practice!", Url = "7", ImageUrl = "7_ital.jpeg", OneHourPrice = 170, Gender = "Woman", Age = 27, DateAdded = DateTime.Now , LanguageId = 3 ,EmailAdres= "alessamalessa@example.com" },
                new Instructor() { Id = 8, Name = "Aureliano", LastName = "Moro", Description = "Hello, I'm Italian. Let's make practice!", Url = "8", ImageUrl = "8_ital.jpeg", OneHourPrice = 150, Gender = "Man", Age = 44, DateAdded = DateTime.Now , LanguageId = 3 , EmailAdres= "aureliaonomoro@example.com" },
                new Instructor() { Id = 9, Name = "Oreste", LastName = "Mokar", Description = "Hello, I'm Italian. Let's make practice!", Url = "9", ImageUrl = "9_ital.jpeg", OneHourPrice = 180, Gender = "Man", Age = 34, DateAdded = DateTime.Now , LanguageId = 3 , EmailAdres= "orestemokar@example.com" },
                new Instructor() { Id = 10, Name = "I-seo", LastName = "Si-woo", Description = "Hello, I'm Korean. Let's make practice!", Url = "10", ImageUrl = "10_kor.jpg", OneHourPrice = 190, Gender = "Woman", Age = 25, DateAdded = DateTime.Now , LanguageId = 4 , EmailAdres= "iseosiwoo@example.com" },
                new Instructor() { Id = 11, Name = "Ye-jun", LastName = "Po-ju", Description = "Hello, I'm Korean. Let's make practice!", Url = "11", ImageUrl = "11_kor.jpg", OneHourPrice = 120, Gender = "Woman", Age = 21, DateAdded = DateTime.Now , LanguageId = 4 , EmailAdres= "yejunpoju@example.com" },
                new Instructor() { Id = 12, Name = "Eunseo", LastName = "Seoyun", Description = "Hello, I'm Korean. Let's make practice!", Url = "12", ImageUrl = "12_kor.jpg", OneHourPrice = 150, Gender = "Woman", Age = 19, DateAdded = DateTime.Now , LanguageId = 4 , EmailAdres= "eunseoseoyun@example.com" });

            modelBuilder
                .Entity<Language>()
                .HasData(
                new Language() { LanguageId = 1, Name = "English" , Url="learnenglish" , ImageUrl="english.jpeg" },
                new Language() { LanguageId = 2, Name = "Germany" , Url="learngermany" , ImageUrl="germany.jpeg" },
                new Language() { LanguageId = 3, Name = "Italian" , Url="learnitalian" , ImageUrl="italy.jpeg" },
                new Language() { LanguageId = 4, Name = "Korean" , Url="learnkorean" , ImageUrl="korean.jpeg" });

        }
    }
}
