using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFLow.Models;
namespace TaskFLow.Interfaces
{
    public interface ITaskRepository
    {
        void Add(TaskItem task);
        List<TaskItem> GetAll();
        TaskItem GetById(Guid taskId);
        void Delete(Guid taskId);
        void Update(TaskItem task);

    }
}
