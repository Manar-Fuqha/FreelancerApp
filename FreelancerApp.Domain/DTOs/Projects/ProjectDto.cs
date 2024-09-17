using FreelancerApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Domain.DTOs.Projects
{
    public class ProjectDto
    {

        public Guid Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Guid clientId { get; set; }
        public Guid? freelancerId { get; set; }

        // Freelancer information
        public string FreelancerName { get; set; }
        public string FreelancerEmail { get; set; }
        public string FreelancerSkillSet { get; set; }
        public decimal FreelancerHourlyRate { get; set; }

        // Client information
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
    }
}
