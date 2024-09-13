using Microsoft.EntityFrameworkCore;
using FreelancerApp.Domain.Models;

namespace FreelancerApp.Infrastructure
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Guid freelancerId = Guid.Parse("21817b57-34dd-436c-a9ee-225dfe69a964");
            Guid clientId = Guid.Parse("c70806dc-ebd7-4d9e-b2ff-497a78d5e4f1");
            Guid projectId = Guid.Parse("c411dae6-2ca6-4ea7-9f1a-b366f9f518d5");
            Guid paymentId = Guid.Parse("f0d07917-0677-41d3-be54-121a080a6120");


            modelBuilder.Entity<Freelancer>().HasData(
                new Freelancer
                {
                    Id = freelancerId,
                    name = "Manar",
                    email = "ManarFuqha@gmail.com",
                    skillSet = "C#, ASP.NET, Java, SQL",
                    hourlyRate = 50
                }
            );

            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Id = clientId,
                    name = "Ahmad",
                    email = "ahmad@gmail.com"
                }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = projectId,
                    title = "Website Development",
                    description = "Build a corporate website",
                    clientId = clientId  
                }
            );

            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    Id = paymentId,
                    date = DateTime.Now,
                    amount = 300,
                    freelancerId = freelancerId,  
                    projectId = projectId  
                }
            
                );
        }

        public DbSet<Freelancer> Freelancer { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
