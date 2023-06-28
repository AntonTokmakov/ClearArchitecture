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
        public string task_name { get; set; }
        [Display(Name = "Описание задачи")]
        public string task_description { get; set; }
        [Display(Name = "Сложность задачи")]
        public int id_complexity_task { get; set; }
        /*[Display(Name = "Дата начала")]
        public string start_date { get; set; }
        [Display(Name = "Дата окончания")]
        public string end_date { get; set; }*/
        public int id_project { get; set; }
        [Display(Name = "Создавший студент")]
        public int id_student { get; set; }
        public int? parent { get; set; }
        public int? child { get; set; }
        [Display(Name = "Видимость задачи")]
        public bool visible { get; set; }
        [Display(Name = "Статус задачи")]
        public int id_status { get; set; }
        /*[Display(Name = "Реальная дата окончания")]
        public string actual_end_date { get; set; }*/
    }
}