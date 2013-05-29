using System.Data.Entity;
using Juve.Data.Abstractions;
using Juve.Model;

namespace Juve.Data.Concrete
{
    public class TeamsRepository : BaseRepository<Team>, ITeamsRepository
    {
        public TeamsRepository(DbContext context) : base(context)
        {
        }
    }
}
