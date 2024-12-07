using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pagination.Data;
using Pagination.DTOs;
using Pagination.Models;

namespace Pagination.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly StudentContext _context;
        public FileController(StudentContext studentContext)
        {
            _context = studentContext;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Add([FromForm] FileDto fileDto)
        {
            if (fileDto.ImageFile.Length == 0 || fileDto.ImageFile == null)
            {
                return BadRequest("Invalid File");
            }

            // Generate a unique filename to avoid conflicts
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(fileDto.ImageFile.FileName)}";

            // Combine the path to the wwwroot folder and the folder where images will be stored
            var imagePath = Path.Combine("wwwroot", "images", fileName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await fileDto.ImageFile.CopyToAsync(fileStream);
            }
            // File is created

            // This will save the file information to the database
            var fileUpload = new FileUpload
            {
                Id = Guid.NewGuid(),
                FileName = fileDto.FileName,
                FilePath = $"images/{fileName}"
            };
            fileUpload.FilePath = $"images/{fileName}";
            _context.Files.Add(fileUpload);
            _context.SaveChanges();

            return Ok();
        }



    }
}
