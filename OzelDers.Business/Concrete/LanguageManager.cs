using System;
using OzelDers.Business.Abstract;
using OzelDers.Data.Abstract;
using OzelDers.Data.Concrete;
using OzelDers.Entity;

namespace OzelDers.Business.Concrete
{
    public class LanguageManager : ILanguageService
    {
        private ILanguageRepository _languageRepository;

        public LanguageManager(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public void Create(Language entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Language entity)
        {
            throw new NotImplementedException();
        }

        public List<Language> GetAll()
        {
            return _languageRepository.GetAll();
        }

        public Language GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Language entity)
        {
            throw new NotImplementedException();
        }
    }
}

