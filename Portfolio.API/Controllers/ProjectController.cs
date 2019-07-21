using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.API.Models;
using Portfolio.Core.Domain;
using Portfolio.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.API.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ProjectController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<ProjectController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/projects
        [HttpGet]
        public IActionResult Get()
        {
            var projects = _unitOfWork.Projects.GetAllProjects();
            IEnumerable<ProjectModel> projectModelList = _mapper.Map<IEnumerable<Project>, IEnumerable<ProjectModel>>(projects);

            return Ok(projectModelList);
        }

        // GET: api/projects/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var project = _unitOfWork.Projects.GetProjectById(id);
            ProjectModel projectModel = _mapper.Map<Project, ProjectModel>(project);

            return Ok(projectModel);
        }
    }
}