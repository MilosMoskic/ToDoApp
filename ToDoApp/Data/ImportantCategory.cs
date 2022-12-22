using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Data
{
    public enum ImportantCategory
    {
        NotStarted,
        Starting,
        [Display(Name = "In progress")]
        InProgress,
        Completed
    }
}
