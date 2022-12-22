using System.ComponentModel.DataAnnotations;
using ToDoApp.Data;

namespace ToDoApp.Models
{
    public class Taskk
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public ImportantCategory Importance { get; set; } = ImportantCategory.Starting;
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
    }
}
