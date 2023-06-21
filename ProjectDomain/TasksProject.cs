using Microsoft.EntityFrameworkCore;
using Tasks.Models;

namespace TrialProject.Models
{
    [PrimaryKey("id_task")]
    public class TasksProject
    {
        public int id_task { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Complexity { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int IdProject { get; set; }
        public string CreatStudent { get; set; }
        public int Parent { get; set; }
        public int Child { get; set; }
        public bool Visible { get; set; }
        public Student[] Students { get; set; }
    }
}
