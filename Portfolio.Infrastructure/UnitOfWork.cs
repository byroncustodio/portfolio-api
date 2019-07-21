using Portfolio.Infrastructure.Repositories.Domain;
using Portfolio.Infrastructure.Repositories.Interfaces;

namespace Portfolio.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _context;

        IImageRepository _images;
        IProjectRepository _projects;
        ITechnologyRepository _technologies;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IImageRepository Images
        {
            get
            {
                if (_images == null)
                {
                    _images = new ImageRepository(_context);
                }

                return _images;
            }
        }

        public IProjectRepository Projects
        {
            get
            {
                if (_projects == null)
                {
                    _projects = new ProjectRepository(_context);
                }

                return _projects;
            }
        }

        public ITechnologyRepository Technologies
        {
            get
            {
                if (_technologies == null)
                {
                    _technologies = new TechnologyRepository(_context);
                }

                return _technologies;
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}