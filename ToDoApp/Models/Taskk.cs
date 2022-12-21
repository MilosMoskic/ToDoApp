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
        public ImportantCategory Importance { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{HH:mm}")]
        public DateTime FromTime { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{HH:mm}")]
        public DateTime ToTime { get; set; }
    }
}
