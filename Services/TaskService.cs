using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFLow.Interfaces;
using TaskFLow.Models;

namespace TaskFLow.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public TaskItem CreateTask(TaskItemRequest task)
        {
            TaskItem taskItem = new TaskItem();
            taskItem.Id = Guid.NewGuid();
            taskItem.Title = task.Title;
            taskItem.Description = task.Description;
            _taskRepository.Add(taskItem);
            return taskItem;
        }

        public bool DeleteTask(Guid taskId)
        {
            return _taskRepository.Delete(taskId);
        }

        public List<TaskItem> GetAllTasks()
        {
           return  _taskRepository.GetAll();
        }

        public TaskItem? GetTaskById(Guid taskId)
        {
            return _taskRepository.GetById(taskId);
        }

        public bool UpdateTask(TaskUpdateItem task, Guid id)
        {
            TaskItem item = new TaskItem();
            item.Id = id;
            item.Title = task.Title;
            item.Description = task.Description;
            item.IsCompleted = task.IsCompleted;
            return _taskRepository.Update(item);
        }
    }
}
