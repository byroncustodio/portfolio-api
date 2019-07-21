using Portfolio.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Portfolio.Infrastructure
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
	        modelBuilder.Entity<Image>().HasData(
                new Image { Id = 1, Url = "/assets/images/advrtas-cms-thumb.png", Alt = "Advrtas CMS Thumbnail" },
                new Image { Id = 2, Url = "/assets/images/memxpress-thumb.png", Alt = "Memory Express Thumbnail" }
            );

            modelBuilder.Entity<Technology>().HasData(
                new Technology { Id = 1, Name = "ASP.NET MVC" },
                new Technology { Id = 2, Name = "ASP.NET WebAPI" },
                new Technology { Id = 3, Name = "ASP.NET Core" },
                new Technology { Id = 4, Name = "ADO.NET" },
                new Technology { Id = 5, Name = "Entity Framework" },
                new Technology { Id = 6, Name = "Azure SQL Database" },
                new Technology { Id = 7, Name = "Azure Storage" },
                new Technology { Id = 8, Name = "Azure App Service" },
                new Technology { Id = 9, Name = "Angular 6" },
                new Technology { Id = 10, Name = "Angular 7" },
                new Technology { Id = 11, Name = "Bootstrap" },
                new Technology { Id = 12, Name = "SQL Server" }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Title = "Advrtas CMS",
                    Description = "An ad development platform built during my time as a .Net Developer with Advrtas. The CMS allowed for custom creation of 360&#176;/VR ads, ad performance monitoring, and distribution through third-party providers.",
                    Body = "",
                    GitUrl = "",
                    LiveUrl = "",
                    SeoUrl = "advrtas-cms",
                    MetaTitle = "",
                    MetaKeywords = "",
                    MetaDescription = "",
                    DateStarted = new DateTime(2018, 7, 1)
                },
                new Project
                {
                    Id = 2,
                    Title = "Memory Express Concept",
                    Description = "A redesign concept for the electronics store Memory Express.",
                    Body = "",
                    GitUrl = "https://github.com/byroncustodio/memory-express-redesign",
                    LiveUrl = "https://memxpress.azurewebsites.net",
                    SeoUrl = "memory-express-concept",
                    MetaTitle = "",
                    MetaKeywords = "",
                    MetaDescription = "",
                    DateStarted = new DateTime(2019, 5, 1)
                },
                new Project
                {
                    Id = 3,
                    Title = "Personal Portfolio",
                    Description = "An online portfolio of my work as a developer.",
                    Body = "",
                    GitUrl = "https://github.com/byroncustodio/portfolio",
                    LiveUrl = "https://byroncustodio.azurewebsites.net",
                    SeoUrl = "personal-portfolio",
                    MetaTitle = "",
                    MetaKeywords = "",
                    MetaDescription = "",
                    DateStarted = new DateTime(2019, 4, 1)
                }
            );

            modelBuilder.Entity<ProjectImageMapping>().HasData(
                new ProjectImageMapping { Id = 1, ProjectId = 1, ImageId = 1 },
                new ProjectImageMapping { Id = 2, ProjectId = 2, ImageId = 2 }
            );

            modelBuilder.Entity<ProjectTechnologyMapping>().HasData(
                new ProjectTechnologyMapping { Id = 1, ProjectId = 1, TechnologyId = 1 },
                new ProjectTechnologyMapping { Id = 2, ProjectId = 1, TechnologyId = 2 },
                new ProjectTechnologyMapping { Id = 3, ProjectId = 1, TechnologyId = 4 },
                new ProjectTechnologyMapping { Id = 4, ProjectId = 1, TechnologyId = 5 },
                new ProjectTechnologyMapping { Id = 5, ProjectId = 1, TechnologyId = 6 },
                new ProjectTechnologyMapping { Id = 6, ProjectId = 1, TechnologyId = 7 },
                new ProjectTechnologyMapping { Id = 7, ProjectId = 1, TechnologyId = 8 },
                new ProjectTechnologyMapping { Id = 8, ProjectId = 1, TechnologyId = 12 },
                new ProjectTechnologyMapping { Id = 9, ProjectId = 2, TechnologyId = 1 },
                new ProjectTechnologyMapping { Id = 10, ProjectId = 2, TechnologyId = 5 },
                new ProjectTechnologyMapping { Id = 11, ProjectId = 2, TechnologyId = 6 },
                new ProjectTechnologyMapping { Id = 12, ProjectId = 2, TechnologyId = 8 },
                new ProjectTechnologyMapping { Id = 13, ProjectId = 3, TechnologyId = 2 },
                new ProjectTechnologyMapping { Id = 14, ProjectId = 3, TechnologyId = 3 },
                new ProjectTechnologyMapping { Id = 15, ProjectId = 3, TechnologyId = 5 },
                new ProjectTechnologyMapping { Id = 16, ProjectId = 3, TechnologyId = 8 },
                new ProjectTechnologyMapping { Id = 17, ProjectId = 3, TechnologyId = 9 },
                new ProjectTechnologyMapping { Id = 18, ProjectId = 3, TechnologyId = 11 }
            );
        }
    }
}