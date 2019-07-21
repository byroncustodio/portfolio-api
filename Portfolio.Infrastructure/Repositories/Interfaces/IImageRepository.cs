using Portfolio.Core.Domain;
using System;
using System.Collections.Generic;

namespace Portfolio.Infrastructure.Repositories.Interfaces
{
    public interface IImageRepository : IRepository<Image>
    {
        IEnumerable<Image> GetAllImages();
    }
}