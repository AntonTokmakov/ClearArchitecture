namespace Tasks.Controllers.Repositories;
using TrialProject.Models;

public class SQLTaskProject : IRepository<TasksProject>
{
    private ProjectContext db;

    public SQLTaskProject(ProjectContext context)
    {
        this.db = context;
    }

    public void Create(TasksProject task)
    {
        db.task.Add(task);
    }

    public void Delete(int id)
    {
        TasksProject task = db.task.Find(id);
        if (task != null)
        {
            db.task.Remove(task);
        }
    }

    public TasksProject GetItem(int id)
    {
        return db.task.Find(id);
    }

    public IEnumerable<TasksProject> GetItemList()
    {
        return db.task;
    }

    public void Save()
    {
        db.SaveChanges();
    }

    public void Update(TasksProject task)
    {
        db.task.Update(task);
    }
}
