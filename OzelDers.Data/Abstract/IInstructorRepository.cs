using System;
using System.Linq.Expressions;
using OzelDers.Entity;

namespace OzelDers.Data.Abstract
{
    public interface IInstructorRepository : IRepository<Instructor>
    {
        List<Instructor> GetInstructorsByLanguage(string language, int page, int pageSize);
        Instructor GetInstructorDetails(string url);
        int GetCountByLanguage(string language);
        List<Instructor> GetSearchResult(string searchString);
     
    }
}

