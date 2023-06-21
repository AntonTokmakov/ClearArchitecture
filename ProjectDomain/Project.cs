using Microsoft.EntityFrameworkCore;

namespace Tasks.Models;

[PrimaryKey("id_project")]
public class Project
{
    public int id_project { get; set; }
    public string project_name { get; set; }
    public int id_ts { get; set; }
    public string short_name { get; set; }
    public int id_status { get; set; }
}
