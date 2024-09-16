using FreelancerApp.Application.Services.Abstracts;
using FreelancerApp.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(bool includeClient , bool includeFreelance)
        {
            return Ok(await projectService.GetAllProjects(includeClient , includeFreelance));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id , bool includeClient , bool includeFreelance)
        {
            return Ok(await projectService.GetProjectById(id , includeClient , includeFreelance));
        }

        [HttpPost]
        public async Task<IActionResult> Create (Project project)
        {
            await projectService.Create(project);
            return Ok("Created Successfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id , Project project)
        {
            await projectService.Update(id , project);
            return Ok("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete( Guid id)
        {
            await projectService.Delete(id);
            return Ok("Deleted Successfully");
        }
       
    }
}
