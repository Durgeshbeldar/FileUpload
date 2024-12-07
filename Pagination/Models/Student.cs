using System.ComponentModel.DataAnnotations;

namespace Pagination.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Address { get; set; }
    }
}
