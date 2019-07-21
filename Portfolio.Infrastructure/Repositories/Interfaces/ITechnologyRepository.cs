using Portfolio.Core.Domain;
using System;
using System.Collections.Generic;

namespace Portfolio.Infrastructure.Repositories.Interfaces
{
    public interface ITechnologyRepository : IRepository<Technology>
    {
        IEnumerable<Technology> GetAllTechnologies();
    }
}