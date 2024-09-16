
using FreelancerApp.Application.Services.Abstracts;
using FreelancerApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreelancerController : ControllerBase
    {
        private readonly IFreelancerService freelancerService;

        public FreelancerController(IFreelancerService freelancerService)
        {
            this.freelancerService = freelancerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok( await freelancerService.GetAllFreelancers());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAFreelance(Guid id)
        {
           return Ok( await freelancerService.GetFreelacerById(id));

        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Freelancer freelancer)
        {
            return Ok(await freelancerService.Create(freelancer)) ;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id , [FromBody] Freelancer freelancer)
        {
            await freelancerService.Update(id, freelancer);
            return Ok("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await freelancerService.Delete(id);
            return Ok("Deleted Successfully");
        }
    }
}
