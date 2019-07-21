using Portfolio.Core.Domain;
using Portfolio.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Infrastructure.Repositories.Domain
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public ProjectRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Project> GetAllProjects()
        {
            return _appContext.Projects
                .Include(pi => pi.Images).ThenInclude(i => i.Image)
                .Include(pt => pt.Technologies).ThenInclude(t => t.Technology)
                .OrderByDescending(x => x.DateStarted)
                .ToList();
        }

        public Project GetProjectById(int id)
        {
            return _appContext.Projects
                .Where(p => p.Id == id)
                .Include(pt => pt.Technologies).ThenInclude(t => t.Technology)
                .SingleOrDefault();
        }
    }
}