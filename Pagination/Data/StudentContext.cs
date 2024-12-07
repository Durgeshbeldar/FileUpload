using Microsoft.EntityFrameworkCore;
using Pagination.Models;

namespace Pagination.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<FileUpload> Files { get; set; }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
               new Student { Id = Guid.NewGuid(), Name = "Shyam Kumavat", RollNo = 23, Address = "Nagpur" },
                new Student { Id = Guid.NewGuid(), Name = "Amit Kumar", RollNo = 24, Address = "Mumbai" },
                new Student { Id = Guid.NewGuid(), Name = "Priya Verma", RollNo = 25, Address = "Pune" },
                new Student { Id = Guid.NewGuid(), Name = "Neha Joshi", RollNo = 26, Address = "Nagpur" },
                new Student { Id = Guid.NewGuid(), Name = "Raj Patel", RollNo = 27, Address = "Delhi" },
                new Student { Id = Guid.NewGuid(), Name = "Ankit Singh", RollNo = 28, Address = "Chennai" },
                new Student { Id = Guid.NewGuid(), Name = "Ravi Sharma", RollNo = 29, Address = "Mumbai" },
                new Student { Id = Guid.NewGuid(), Name = "Simran Kaur", RollNo = 30, Address = "Pune" },
                new Student { Id = Guid.NewGuid(), Name = "Vikram Yadav", RollNo = 31, Address = "Delhi" },
                new Student { Id = Guid.NewGuid(), Name = "Aarti Agarwal", RollNo = 32, Address = "Nagpur" },
                new Student { Id = Guid.NewGuid(), Name = "Manish Joshi", RollNo = 33, Address = "Chennai" },
                new Student { Id = Guid.NewGuid(), Name = "Tanvi Mehta", RollNo = 34, Address = "Mumbai" },
                new Student { Id = Guid.NewGuid(), Name = "Karan Deshmukh", RollNo = 35, Address = "Pune" },
                new Student { Id = Guid.NewGuid(), Name = "Nikita Singh", RollNo = 36, Address = "Nagpur" },
                new Student { Id = Guid.NewGuid(), Name = "Pradeep Kumar", RollNo = 37, Address = "Delhi" },
                new Student { Id = Guid.NewGuid(), Name = "Sakshi Sharma", RollNo = 38, Address = "Chennai" },
                new Student { Id = Guid.NewGuid(), Name = "Ritika Patel", RollNo = 39, Address = "Mumbai" },
                new Student { Id = Guid.NewGuid(), Name = "Akhil Gupta", RollNo = 40, Address = "Pune" },
                new Student { Id = Guid.NewGuid(), Name = "Mehul Jain", RollNo = 41, Address = "Nagpur" },
                new Student { Id = Guid.NewGuid(), Name = "Parul Sharma", RollNo = 42, Address = "Delhi" },
                new Student { Id = Guid.NewGuid(), Name = "Siddharth Thakur", RollNo = 43, Address = "Chennai" },
                new Student { Id = Guid.NewGuid(), Name = "Isha Gupta", RollNo = 44, Address = "Mumbai" },
                new Student { Id = Guid.NewGuid(), Name = "Tarun Kumar", RollNo = 45, Address = "Pune" },
                new Student { Id = Guid.NewGuid(), Name = "Kajal Verma", RollNo = 46, Address = "Nagpur" },
                new Student { Id = Guid.NewGuid(), Name = "Devika Reddy", RollNo = 47, Address = "Delhi" },
                new Student { Id = Guid.NewGuid(), Name = "Rohit Pandey", RollNo = 48, Address = "Chennai" },
                new Student { Id = Guid.NewGuid(), Name = "Harshita Singh", RollNo = 49, Address = "Mumbai" },
                new Student { Id = Guid.NewGuid(), Name = "Sandeep Raghav", RollNo = 50, Address = "Pune" },
                new Student { Id = Guid.NewGuid(), Name = "Madhuri Gupta", RollNo = 51, Address = "Nagpur" },
                new Student { Id = Guid.NewGuid(), Name = "Pranav Joshi", RollNo = 52, Address = "Delhi" },
                new Student { Id = Guid.NewGuid(), Name = "Gaurav Patil", RollNo = 53, Address = "Chennai" },
                new Student { Id = Guid.NewGuid(), Name = "Sonali Verma", RollNo = 54, Address = "Mumbai" },
                new Student { Id = Guid.NewGuid(), Name = "Tushar Yadav", RollNo = 55, Address = "Pune" },
                new Student { Id = Guid.NewGuid(), Name = "Pooja Mehta", RollNo = 56, Address = "Nagpur" },
                new Student { Id = Guid.NewGuid(), Name = "Vishal Kumar", RollNo = 57, Address = "Delhi" }

           );

        }
    }
}
