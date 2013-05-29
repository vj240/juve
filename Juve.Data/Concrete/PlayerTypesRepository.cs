using System.Data.Entity;
using Juve.Data.Abstractions;
using Juve.Model;

namespace Juve.Data.Concrete
{
    public class PlayerTypesRepository : BaseRepository<PlayerType>, IPlayerTypesRepository
    {
        public PlayerTypesRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }

}
