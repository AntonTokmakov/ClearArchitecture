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
        db.tasks.Add(task);
    }

    public void Delete(int id)
    {
        TasksProject task = db.tasks.Find(id);
        if (task != null)
        {
            db.tasks.Remove(task);
        }
    }

    public TasksProject GetItem(int id)
    {
        return db.tasks.Find(id);
    }

    public IEnumerable<TasksProject> GetItemList()
    {
        return db.tasks;
    }

    public void Save()
    {
        db.SaveChanges();
    }

    public void Update(TasksProject task)
    {
        db.tasks.Update(task);
    }
}
