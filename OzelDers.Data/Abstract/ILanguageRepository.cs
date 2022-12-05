using System;
using OzelDers.Entity;
using System.Linq.Expressions;

namespace OzelDers.Data.Abstract
{
    public interface ILanguageRepository : IRepository<Language>
    {
        List<Language> GetLanguagesWithInstructors();
    }
}

