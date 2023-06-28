using Tasks.Models;
using TrialProject.Models;

namespace ProjectDomain
{
    public class ProjectAndTask
    {
        public Project Project { get; set; }
        public List<TasksProject> Tasks { get; set;}
    }
}
