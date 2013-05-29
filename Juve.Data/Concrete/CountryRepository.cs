using System.Data.Entity;
using Juve.Data.Abstractions;
using Juve.Model;

namespace Juve.Data.Concrete
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}
