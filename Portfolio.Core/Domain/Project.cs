using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Core.Domain 
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        public ICollection<ProjectImageMapping> Images { get; set; }
        public ICollection<ProjectTechnologyMapping> Technologies { get; set; }
    }
}