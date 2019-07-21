using Portfolio.Core.Domain;
using Portfolio.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Infrastructure.Repositories.Domain
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public ImageRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<Image> GetAllImages()
        {
            return _appContext.Images
                .ToList();
        }
    }
}