using System;
using System.Collections.Generic;

namespace Portfolio.API.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }

        public string GitUrl { get; set; }
        public string LiveUrl { get; set; }

        public string SeoUrl { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }

        public DateTime DateStarted { get; set; }

        public List<ImageModel> Images { get; set; }
        public List<TechnologyModel> Technologies { get; set; }
    }
}