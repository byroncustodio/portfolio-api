﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Portfolio.Infrastructure;

namespace Portfolio.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Portfolio.Core.Domain.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alt");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alt = "Advrtas CMS Thumbnail",
                            Url = "/assets/images/advrtas-cms-thumb.png"
                        },
                        new
                        {
                            Id = 2,
                            Alt = "Memory Express Thumbnail",
                            Url = "/assets/images/memxpress-thumb.png"
                        });
                });

            modelBuilder.Entity("Portfolio.Core.Domain.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateStarted");

                    b.Property<string>("Description");

                    b.Property<string>("GitUrl");

                    b.Property<string>("LiveUrl");

                    b.Property<string>("MetaDescription");

                    b.Property<string>("MetaKeywords");

                    b.Property<string>("MetaTitle");

                    b.Property<string>("SeoUrl");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "",
                            DateStarted = new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An ad development platform built during my time as a .Net Developer with Advrtas. The CMS allowed for custom creation of 360&#176;/VR ads, ad performance monitoring, and distribution through third-party providers.",
                            GitUrl = "",
                            LiveUrl = "",
                            MetaDescription = "",
                            MetaKeywords = "",
                            MetaTitle = "",
                            SeoUrl = "advrtas-cms",
                            Title = "Advrtas CMS"
                        },
                        new
                        {
                            Id = 2,
                            Body = "",
                            DateStarted = new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A redesign concept for the electronics store Memory Express.",
                            GitUrl = "https://github.com/byroncustodio/memory-express-redesign",
                            LiveUrl = "https://memxpress.azurewebsites.net",
                            MetaDescription = "",
                            MetaKeywords = "",
                            MetaTitle = "",
                            SeoUrl = "memory-express-concept",
                            Title = "Memory Express Concept"
                        },
                        new
                        {
                            Id = 3,
                            Body = "",
                            DateStarted = new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "An online portfolio of my work as a developer.",
                            GitUrl = "https://github.com/byroncustodio/portfolio",
                            LiveUrl = "https://byroncustodio.azurewebsites.net",
                            MetaDescription = "",
                            MetaKeywords = "",
                            MetaTitle = "",
                            SeoUrl = "personal-portfolio",
                            Title = "Personal Portfolio"
                        });
                });

            modelBuilder.Entity("Portfolio.Core.Domain.ProjectImageMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ImageId");

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectImageMapping");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageId = 1,
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageId = 2,
                            ProjectId = 2
                        });
                });

            modelBuilder.Entity("Portfolio.Core.Domain.ProjectTechnologyMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProjectId");

                    b.Property<int>("TechnologyId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TechnologyId");

                    b.ToTable("ProjectTechnologyMapping");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProjectId = 1,
                            TechnologyId = 1
                        },
                        new
                        {
                            Id = 2,
                            ProjectId = 1,
                            TechnologyId = 2
                        },
                        new
                        {
                            Id = 3,
                            ProjectId = 1,
                            TechnologyId = 4
                        },
                        new
                        {
                            Id = 4,
                            ProjectId = 1,
                            TechnologyId = 5
                        },
                        new
                        {
                            Id = 5,
                            ProjectId = 1,
                            TechnologyId = 6
                        },
                        new
                        {
                            Id = 6,
                            ProjectId = 1,
                            TechnologyId = 7
                        },
                        new
                        {
                            Id = 7,
                            ProjectId = 1,
                            TechnologyId = 8
                        },
                        new
                        {
                            Id = 8,
                            ProjectId = 1,
                            TechnologyId = 12
                        },
                        new
                        {
                            Id = 9,
                            ProjectId = 2,
                            TechnologyId = 1
                        },
                        new
                        {
                            Id = 10,
                            ProjectId = 2,
                            TechnologyId = 5
                        },
                        new
                        {
                            Id = 11,
                            ProjectId = 2,
                            TechnologyId = 6
                        },
                        new
                        {
                            Id = 12,
                            ProjectId = 2,
                            TechnologyId = 8
                        },
                        new
                        {
                            Id = 13,
                            ProjectId = 3,
                            TechnologyId = 2
                        },
                        new
                        {
                            Id = 14,
                            ProjectId = 3,
                            TechnologyId = 3
                        },
                        new
                        {
                            Id = 15,
                            ProjectId = 3,
                            TechnologyId = 5
                        },
                        new
                        {
                            Id = 16,
                            ProjectId = 3,
                            TechnologyId = 8
                        },
                        new
                        {
                            Id = 17,
                            ProjectId = 3,
                            TechnologyId = 9
                        },
                        new
                        {
                            Id = 18,
                            ProjectId = 3,
                            TechnologyId = 11
                        });
                });

            modelBuilder.Entity("Portfolio.Core.Domain.Technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Technology");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ASP.NET MVC"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ASP.NET WebAPI"
                        },
                        new
                        {
                            Id = 3,
                            Name = "ASP.NET Core"
                        },
                        new
                        {
                            Id = 4,
                            Name = "ADO.NET"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Entity Framework"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Azure SQL Database"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Azure Storage"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Azure App Service"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Angular 6"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Angular 7"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Bootstrap"
                        },
                        new
                        {
                            Id = 12,
                            Name = "SQL Server"
                        });
                });

            modelBuilder.Entity("Portfolio.Core.Domain.ProjectImageMapping", b =>
                {
                    b.HasOne("Portfolio.Core.Domain.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portfolio.Core.Domain.Project", "Project")
                        .WithMany("Images")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portfolio.Core.Domain.ProjectTechnologyMapping", b =>
                {
                    b.HasOne("Portfolio.Core.Domain.Project", "Project")
                        .WithMany("Technologies")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portfolio.Core.Domain.Technology", "Technology")
                        .WithMany()
                        .HasForeignKey("TechnologyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}