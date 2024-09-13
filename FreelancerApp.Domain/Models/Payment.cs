namespace FreelancerApp.Domain.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public decimal amount { get; set; }
        public DateTime date { get; set; }

        public Guid freelancerId { get; set; }
        public Freelancer freelancer { get; set; }
        public Guid projectId { get; set; }
        public Project project { get; set; }
    }
}
