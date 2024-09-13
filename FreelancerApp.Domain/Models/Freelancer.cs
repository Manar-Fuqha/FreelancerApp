namespace FreelancerApp.Domain.Models
{
    public class Freelancer
    {

        public Guid Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string skillSet { get; set; }
        public decimal hourlyRate { get; set; }

    }
}
