namespace FreelancerApp.Domain.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
