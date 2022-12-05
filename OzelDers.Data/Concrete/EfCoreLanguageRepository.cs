using System;
using System.Linq.Expressions;
using OzelDers.Data.Abstract;
using OzelDers.Entity;

namespace OzelDers.Data.Concrete
{
    public class EfCoreLanguageRepository : EfCoreGenericRepository<Language>, ILanguageRepository
    {
        public EfCoreLanguageRepository(MyAppContext _dbContext) : base(_dbContext)
        {

        }

        private MyAppContext context
        {
            get { return _dbContext as MyAppContext; }
        }

        public List<Language> GetLanguagesWithInstructors()
        {
            throw new NotImplementedException();
        }
    }
}

