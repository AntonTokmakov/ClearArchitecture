using Microsoft.EntityFrameworkCore;

namespace Tasks.Models
{
    public class ProjectTeam
    {
        public int id_project { get; set; }
        public int id_student { get; set; }
    }
}
