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
        bool Delete(Guid taskId);
        bool Update(TaskItem task);

    }
}
