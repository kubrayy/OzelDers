using System;
using Microsoft.EntityFrameworkCore;
using OzelDers.Data.Abstract;
using OzelDers.Entity;

namespace OzelDers.Data.Concrete
{
    public class EfCoreStudentRepository : EfCoreGenericRepository<Student>, IStudentRepository
    {
        public EfCoreStudentRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}

