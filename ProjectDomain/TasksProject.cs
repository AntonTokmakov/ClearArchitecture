using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Tasks.Models;

namespace TrialProject.Models
{
    [PrimaryKey("id_task")]
    public class TasksProject
    {
        public int id_task { get; set; }
        [Display(Name = "Наименование задачи")]
        public string Name { get; set; }
        [Display(Name = "Описание задачи")]
        public string Description { get; set; }
        [Display(Name = "Сложность задачи")]
        public string Complexity { get; set; }
        [Display(Name = "Дата начала")]
        public string StartDate { get; set; }
        [Display(Name = "Дата окончания")]
        public string EndDate { get; set; }
        public int IdProject { get; set; }
        [Display(Name = "Создавший студент")]
        public string CreatStudent { get; set; }
        public int Parent { get; set; }
        public int Child { get; set; }
        [Display(Name = "Видимость задачи")]
        public bool Visible { get; set; }
        [Display(Name = "Студенты отвественные за задачу")]
        public Student[] Students { get; set; }
    }
}
