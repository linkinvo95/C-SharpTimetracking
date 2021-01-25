using System.Collections.Generic;
using BusinessEntities;

namespace Data.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        IEnumerable<Project> Get(string name, int skip, int take);
    }
}