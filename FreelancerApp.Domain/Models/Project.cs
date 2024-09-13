namespace FreelancerApp.Domain.Models
{
    public class Project
    {
        public Guid Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }

        public Guid clientId { get; set; }
        public Client client { get; set; }
        public Guid? freelancerId { get; set; }
        public Freelancer freelancer { get; set; }

    }
}
