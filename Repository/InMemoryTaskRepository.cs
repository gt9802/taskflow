using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskFLow.Interfaces;
using TaskFLow.Models;

namespace TaskFLow.Repository
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private List<TaskItem> tasks = new List<TaskItem>();

        public void Add(TaskItem task)
        {
            tasks.Add(task);
        }

        public bool Delete(Guid taskId)
        {
            TaskItem? task = tasks.FirstOrDefault(t => t.Id == taskId);
            return tasks.Remove(task);
        }

        public List<TaskItem> GetAll()
        {
            return tasks;
        }

        public TaskItem? GetById(Guid taskId)
        {
            return tasks.FirstOrDefault(x => x.Id == taskId);
        }

        public bool Update(TaskItem task)
        {
            TaskItem? t = tasks.FirstOrDefault(x => x.Id == task.Id);
            if (t != null)
            {
                t.Title = task.Title;
                t.Description = task.Description;
                t.IsCompleted = task.IsCompleted;
                return true;
            }
            return false;
        }
    }
}
