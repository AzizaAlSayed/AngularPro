using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularPro.Models;
using AngularPro.Repository;
using AngularPro.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularPro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private  readonly ITaskRepository _taskRepository;
        private  readonly IMapper _mapper;

        public TasksController(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult index()
        {
            var task = _taskRepository.GetAllTasks();
            return Ok(_mapper.Map<IEnumerable<TaskVM>>(task));
        }

        [HttpGet("{TaskId}")]
        public IActionResult GetTask(int TaskId)
        {
            var task = _taskRepository.GetTask(TaskId);
            return Ok(_mapper.Map<TaskVM>(task));

        }

        [HttpPost]
        public IActionResult Create([FromBody] TaskVM Task)
        {
            var task = _mapper.Map<Tasks>(Task); 
            _taskRepository.CreateTask(task);
            return Ok(task);
        }

        [HttpDelete("{TaskId}")]
        public IActionResult Delete(int TaskId)
        {
           
            var task = _taskRepository.GetTask(TaskId);
            if (task == null) return NotFound();
            _taskRepository.Delete(TaskId);
            return Ok();
        }

        [HttpPut("{TaskId}")]
        public IActionResult Update(int TaskId, [FromBody] TaskVM Task)
        {
  
            var task = _taskRepository.GetTask(TaskId);
            if (task == null) return NotFound();
            _mapper.Map(Task, task);
            _taskRepository.update(task);
            return Ok(_mapper.Map<TaskVM>(task));
        }



    }
}

