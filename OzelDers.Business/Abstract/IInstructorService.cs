using System;
using OzelDers.Entity;

namespace OzelDers.Business.Abstract
{
    public interface IInstructorService
    {
        Instructor GetById(int id);
        List<Instructor> GetAll();
        void Create(Instructor entity);
        void Delete(Instructor entity);
        void Update(Instructor entity);
        Instructor GetInstructorDetails(string url);
        List<Instructor> GetInstructorsByLanguage(string language,int page, int pageSize);
        int GetCountByLanguage(string language);
        List<Instructor> GetSearchResult(string searchString);
    }
}

