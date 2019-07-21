using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Portfolio.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Url = table.Column<string>(nullable: true),
                    Alt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    GitUrl = table.Column<string>(nullable: true),
                    LiveUrl = table.Column<string>(nullable: true),
                    SeoUrl = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    MetaKeywords = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    DateStarted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technology",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectImageMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProjectId = table.Column<int>(nullable: false),
                    ImageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectImageMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectImageMapping_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectImageMapping_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTechnologyMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProjectId = table.Column<int>(nullable: false),
                    TechnologyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTechnologyMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTechnologyMapping_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTechnologyMapping_Technology_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "Technology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "Alt", "Url" },
                values: new object[,]
                {
                    { 1, "Advrtas CMS Thumbnail", "/assets/images/advrtas-cms-thumb.png" },
                    { 2, "Memory Express Thumbnail", "/assets/images/memxpress-thumb.png" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Body", "DateStarted", "Description", "GitUrl", "LiveUrl", "MetaDescription", "MetaKeywords", "MetaTitle", "SeoUrl", "Title" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An ad development platform built during my time as a .Net Developer with Advrtas. The CMS allowed for custom creation of 360&#176;/VR ads, ad performance monitoring, and distribution through third-party providers.", "", "", "", "", "", "advrtas-cms", "Advrtas CMS" },
                    { 2, "", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A redesign concept for the electronics store Memory Express.", "https://github.com/byroncustodio/memory-express-redesign", "https://memxpress.azurewebsites.net", "", "", "", "memory-express-concept", "Memory Express Concept" },
                    { 3, "", new DateTime(2019, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "An online portfolio of my work as a developer.", "https://github.com/byroncustodio/portfolio", "https://byroncustodio.azurewebsites.net", "", "", "", "personal-portfolio", "Personal Portfolio" }
                });

            migrationBuilder.InsertData(
                table: "Technology",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Angular 7" },
                    { 9, "Angular 6" },
                    { 8, "Azure App Service" },
                    { 7, "Azure Storage" },
                    { 6, "Azure SQL Database" },
                    { 4, "ADO.NET" },
                    { 11, "Bootstrap" },
                    { 3, "ASP.NET Core" },
                    { 2, "ASP.NET WebAPI" },
                    { 1, "ASP.NET MVC" },
                    { 5, "Entity Framework" },
                    { 12, "SQL Server" }
                });

            migrationBuilder.InsertData(
                table: "ProjectImageMapping",
                columns: new[] { "Id", "ImageId", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTechnologyMapping",
                columns: new[] { "Id", "ProjectId", "TechnologyId" },
                values: new object[,]
                {
                    { 17, 3, 9 },
                    { 16, 3, 8 },
                    { 12, 2, 8 },
                    { 7, 1, 8 },
                    { 6, 1, 7 },
                    { 11, 2, 6 },
                    { 5, 1, 6 },
                    { 15, 3, 5 },
                    { 10, 2, 5 },
                    { 4, 1, 5 },
                    { 3, 1, 4 },
                    { 14, 3, 3 },
                    { 13, 3, 2 },
                    { 2, 1, 2 },
                    { 9, 2, 1 },
                    { 1, 1, 1 },
                    { 18, 3, 11 },
                    { 8, 1, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImageMapping_ImageId",
                table: "ProjectImageMapping",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectImageMapping_ProjectId",
                table: "ProjectImageMapping",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologyMapping_ProjectId",
                table: "ProjectTechnologyMapping",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologyMapping_TechnologyId",
                table: "ProjectTechnologyMapping",
                column: "TechnologyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectImageMapping");

            migrationBuilder.DropTable(
                name: "ProjectTechnologyMapping");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Technology");
        }
    }
}
