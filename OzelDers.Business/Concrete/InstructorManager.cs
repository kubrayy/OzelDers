using System;
using OzelDers.Business.Abstract;
using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete;
using OzelDers.Entity;

namespace OzelDers.Business.Concrete
{
    public class InstructorManager : IInstructorService
    {

        private IInstructorRepository _instructorRepository;

        public InstructorManager(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }


        public void Create(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Instructor entity)
        {
            _instructorRepository.Delete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _instructorRepository.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorRepository.GetById(id);
        }

        public int GetCountByLanguage(string language)
        {
            return _instructorRepository.GetCountByLanguage(language);
        }

        public Instructor GetInstructorDetails(string url)
        {
            return _instructorRepository.GetInstructorDetails(url);
        }

        public List<Instructor> GetInstructorsByLanguage(string language, int page, int pageSize)
        {
            return _instructorRepository.GetInstructorsByLanguage(language, page, pageSize);
        }

        public List<Instructor> GetSearchResult(string searchString)
        {
            return _instructorRepository.GetSearchResult(searchString);
        }

        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
}

