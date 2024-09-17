using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancerApp.Domain.DTOs.Freelancers
{
    public class CreateFreelancerDto
    {
        public string name { get; set; }
        public string email { get; set; }
        public string skillSet { get; set; }
        public decimal hourlyRate { get; set; }
    }
}
