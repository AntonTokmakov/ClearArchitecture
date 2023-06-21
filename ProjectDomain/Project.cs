using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Models;

[PrimaryKey("id_project")]
public class Project
{
    public int id_project { get; set; }
    [Required(ErrorMessage = "Заполните наименовние проекта")]
    [Display(Name = "Наименование проекта")]
    public string project_name { get; set; }

    [Required(ErrorMessage = "У проекта обязательно должно быть ТЗ")]
    [Display(Name = "ТЗ проекта")]
    public int id_ts { get; set; }

    [Required(ErrorMessage = "Заполните короткое наименовние проекта")]
    [Display(Name = "Короткое наименованеи проекта")]
    public string short_name { get; set; }

    [Required(ErrorMessage = "Заполните в каком статусе проекта")]
    [Display(Name = "Статуст проекта")]
    public int id_status { get; set; }
}
