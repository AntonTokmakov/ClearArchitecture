using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tasks.Models;

namespace ProjectDomain
{
    public class ProjectAndTask
    {
        public Project Project { get; set; }
        public List<Task> Tasks { get; set;}
    }
}
