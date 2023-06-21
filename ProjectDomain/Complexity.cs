using Microsoft.EntityFrameworkCore;

namespace Tasks.Models
{
    [PrimaryKey("id_complexity")]
    public class Complexity
    {
        public int id_complexity { get; set; }
        public string complexity { get; set; }
    }
}
