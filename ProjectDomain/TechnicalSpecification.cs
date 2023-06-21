using Microsoft.EntityFrameworkCore;

namespace TrialProject.Models
{
    [PrimaryKey("id_ts")]
    public class TechnicalSpecification
    {
        public int id_ts { get; set; }
        public string link_storage_ts { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
    }
}
