using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Domain.DTOs.Projects
{
    public class UpdateProjectRequestDto
    {

        public string? title { get; set; }
        public string? description { get; set; }
        public Guid? clientId { get; set; }
        public Guid? freelancerId { get; set; }

    }
}
