using Microsoft.EntityFrameworkCore;

namespace TrialProject.Models
{
    [PrimaryKey("id_status")]
    public class ProjectTaskStatus
    {
        public int id_status { get; set; }
        public string status { get; set; }
    }
}
