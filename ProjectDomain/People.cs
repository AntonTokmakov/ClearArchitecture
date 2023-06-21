using Microsoft.EntityFrameworkCore;

namespace Tasks.Models
{
    [PrimaryKey("id")]
    public class People
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string otchestvo { get; set; }
    }
}
