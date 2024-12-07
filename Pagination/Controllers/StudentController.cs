using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pagination.Data;

namespace Pagination.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly StudentContext _studentContext;
        public StudentController(StudentContext studentContext)
        {
            _studentContext = studentContext;
        }

        [HttpGet]
        //public IActionResult GetStudentRecords([FromQuery] int pageNumber,[FromQuery] int pageSize)
        //{
        //    if (pageNumber < 1 || pageSize < 1)
        //        return BadRequest("Invalid Request...");
        //    var totalStudents = _studentContext.Students.ToList();
        //    var totalRecords = totalStudents.Count(); 
        //    var students = _studentContext.Students
        //                  .Skip((pageNumber - 1) * pageSize)
        //                  .Take(pageSize)
        //                  .ToList();
        //    return Ok(new { students, totalRecords});
        //}

        public IActionResult GetStudentRecords([FromQuery] string searchQuery, [FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            if (pageNumber < 1 || pageSize < 1)
                return BadRequest("Invalid Request...");

            var query = _studentContext.Students.AsQueryable(); // Start with the full collection of students

            // Fetch all students first
            var studentsList = query.ToList();

            // Apply partial matching for search query (Name and RollNo) in memory (client-side)
            if (!string.IsNullOrEmpty(searchQuery))
            {
                studentsList = studentsList.Where(s =>
                    s.Name.Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                    s.RollNo.ToString().Contains(searchQuery)
                ).ToList();
            }

            // Get total record count after filtering
            var totalRecords = studentsList.Count();

            // Apply pagination (skip and take) on the filtered list
            var students = studentsList
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return Ok(new { students, totalRecords });
        }

    }
}
