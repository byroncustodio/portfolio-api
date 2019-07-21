using Portfolio.Core.Domain;
using System;
using System.Collections.Generic;

namespace Portfolio.Infrastructure.Repositories.Interfaces
{
    public interface IProjectRepository : IRepository<Project>
    {
        IEnumerable<Project> GetAllProjects();

        Project GetProjectById(int id);
    }
}