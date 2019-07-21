using Portfolio.Infrastructure.Repositories.Interfaces;

namespace Portfolio.Infrastructure
{
    public interface IUnitOfWork
    {
        IImageRepository Images { get; }
        IProjectRepository Projects { get; }
        ITechnologyRepository Technologies { get; }

        int SaveChanges();
    }
}