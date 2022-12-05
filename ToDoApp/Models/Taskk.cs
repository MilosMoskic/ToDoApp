using System.ComponentModel.DataAnnotations;
using ToDoApp.Data;

namespace ToDoApp.Models
{
    public class Taskk
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public ImportantCategory Importance { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
