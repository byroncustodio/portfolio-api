using Portfolio.Core.Domain;
using Portfolio.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Infrastructure.Repositories.Domain
{
    public class TechnologyRepository : Repository<Technology>, ITechnologyRepository
    {
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public TechnologyRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Technology> GetAllTechnologies()
        {
            return _appContext.Technologies
                .ToList();
        }
    }
}