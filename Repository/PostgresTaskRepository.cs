using Microsoft.EntityFrameworkCore;
using TaskFLow.Data;
using TaskFLow.Interfaces;
using TaskFLow.Models;

namespace TaskFLow.Repository
{
    public class PostgresTaskRepository : ITaskRepository
    {

        private readonly AppDbContext _db;
        public PostgresTaskRepository(AppDbContext db) { 
            _db = db;
        }
        public void Add(TaskItem task)
        {
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }

        public bool Delete(Guid taskId)
        {
            var task = _db.Tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null) { 
                _db.Tasks.Remove(task);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<TaskItem> GetAll()
        {
            return _db.Tasks.ToList();
        }

        public TaskItem GetById(Guid taskId)
        {
            return _db.Tasks.FirstOrDefault(x => x.Id == taskId);
        }

        public bool Update(TaskItem task)
        {
            _db.Tasks.Update(task);
            _db.SaveChanges();
            return true;
        }
    }
}
