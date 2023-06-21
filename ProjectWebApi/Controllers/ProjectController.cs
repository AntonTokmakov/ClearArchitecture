using Microsoft.AspNetCore.Mvc;
using TrialProject.UseCase;

namespace Tasks.Models
{
    public class ProjectController : Controller
    {
        IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            this._projectService = projectService;
        }

        [HttpPost]
        public IActionResult AddProject(Project project)
        {
            _projectService.AddProject(project);
            return View();
        }

        public IActionResult GetProjects()
        {
            return View(_projectService.GetProjects());
        }
    }


    /*public class ProjectController : IProjectController
    {
        private readonly IProjectService projectService; 

        public ProjectController(IProjectService projectService) 
        {
            this.projectService = projectService;
        }

        public void AddProject(ProjectDto projectDto)
        {
            var project = new Project()
            {
                id_project = projectDto.id_project,
                project_name = projectDto.project_name,
                id_ts = projectDto.id_ts,
                short_name = projectDto.short_name,
                id_status = projectDto.id_status
            };
            projectService.AddProject(project);
        }

        public void DeleteProject(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProjectDto> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public ProjectDto GetProjectById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(ProjectDto projectDto)
        {
            throw new NotImplementedException();
        }
    }*/
}
