using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFLow.Models;
using TaskFLow.Services;
namespace TaskFLow.Controller
{
    [ApiController]
    [Route("tasks")]
    public class TaskController: ControllerBase
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService) { 
            _taskService = taskService;
        }

        [HttpPost]
        public IActionResult create(TaskItemRequest task)  {
           var createdTask =  _taskService.CreateTask(task);
            return Created($"/tasks/{createdTask.Id}",createdTask);
        }
    }
}
