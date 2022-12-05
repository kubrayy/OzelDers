using System;
using OzelDers.Entity;

namespace OzelDers.Business.Abstract
{
    public interface ILanguageService
    {
        Language GetById(int id);
        List<Language> GetAll();
        void Create(Language entity);
        void Delete(Language entity);
        void Update(Language entity);
    }
}

