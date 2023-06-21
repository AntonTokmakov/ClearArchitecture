using Microsoft.EntityFrameworkCore;

namespace Tasks.Models
{
    [PrimaryKey("id_status")]
    public class ProjectStatus
    {
        public int id_status { get; set; }
        public string status { get; set; }
    }
}
