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

        public void Delete(Guid taskId)
        {
            throw new NotImplementedException();
        }

        public List<TaskItem> GetAll()
        {
            return tasks;
        }

        public TaskItem GetById(Guid taskId)
        {
            return tasks.FirstOrDefault(x => x.Id == taskId);
        }

        public void Update(TaskItem task)
        {
            throw new NotImplementedException();
        }
    }
}
