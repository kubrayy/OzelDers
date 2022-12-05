using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Abstract;
using OzelDers.Entity;

namespace OzelDers.Data.Concrete
{
    public class EfCoreInstructorRepository : EfCoreGenericRepository<Instructor>, IInstructorRepository
    {
        public EfCoreInstructorRepository(MyAppContext _dbContext) : base(_dbContext)
        {
        }

        private MyAppContext context
        {
            get { return _dbContext as MyAppContext; }
        }

        public void Create(Instructor instructor, int[] languageIds)
        {
            context.Instructors.Add(instructor);
            context.SaveChanges();
        }

        public int GetCountByLanguage(string language)
        {
            var instructors = context.Instructors.AsQueryable();
            if (!string.IsNullOrEmpty(language))
            {
                instructors = instructors
                    .Include(i => i.Language);
            };
            return instructors.Count();
        }

        public Instructor GetInstructorDetails(string url)
        {
            return context
                .Instructors
                .Where(i => i.Url == url)
                .Include(i => i.Language)
                .FirstOrDefault();
        }


        public List<Instructor> GetInstructorsByLanguage(string language, int page, int pageSize)
        {
            var instructors = context.Instructors.AsQueryable();
            if (!string.IsNullOrEmpty(language))
            {
                instructors = instructors
                    .Include(i => i.Language);
            }
            return instructors
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public List<Instructor> GetSearchResult(string searchString)
        {
            return context
                .Instructors.ToList();
        }
    }
}

