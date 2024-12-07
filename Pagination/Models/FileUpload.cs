using System.ComponentModel.DataAnnotations;

namespace Pagination.Models
{
    public class FileUpload
    {
        [Key]
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
