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
    public class TasksCategoriesController : ControllerBase
    {
        private readonly TasksCategoriesRepository _taskCategoriesRepository;
        //private readonly ITaskRepository _taskRepository;
        //private readonly ICategoriesRepository _categoriesRepository;
        private readonly IMapper _mapper;
        public TasksCategoriesController(TasksCategoriesRepository repository, IMapper mapper)
        {
            _taskCategoriesRepository = repository;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetAll ()
        {

            var taskCategory = _taskCategoriesRepository.GetAllTasksCategories();
          
            return Ok(_mapper.Map<IEnumerable<TaskCategoriesVM>>(taskCategory));
        }
        /*[Route("Task")]
        [HttpGet("{TaskId}")]*/
        public IActionResult GetTaskCategoryByTaskID(int TaskID)
        {
            TasksCategories taskCategory = _taskCategoriesRepository.GetTaskCategoryByTaskID(TaskID);
            return Ok(_mapper.Map<TaskCategoriesVM>(taskCategory));

        }
        /*[Route("Category")]
        [HttpGet("{CategoryId}")]
        public IActionResult GetTaskCategoryByCategoryID(int CategoryID)
        {
            

            var taskCategory = _taskCategoriesRepository.GetTaskCategoryByCarigoryID(CategoryID);
            return Ok(_mapper.Map<TaskCategoriesVM>(taskCategory));

        }
        */
        [HttpPost]
        public IActionResult Create( TaskCategoriesVM TaskCategories )
        {
            /* var task = _taskRepository.GetTask(TaskCategories.TaskId);
             var catigory = _categoriesRepository.GetCategory(TaskCategories.CategoryId);
             if (task == null || catigory == null) return NotFound();*/
            TasksCategories taskCategories = _mapper.Map<TasksCategories>(TaskCategories);
            _taskCategoriesRepository.Create(taskCategories);
            return Ok(taskCategories);
        }

        [HttpPut("{TaskId}")]
        public IActionResult Update(int TaskId, [FromBody] TaskCategoriesVM TaskCategories)
        {
            TasksCategories taskCategories = _taskCategoriesRepository.GetTaskCategoryByTaskID(TaskId);
            if (taskCategories == null) return NotFound();
            _mapper.Map(TaskCategories, taskCategories);
            _taskCategoriesRepository.Update(taskCategories);
            return Ok(_mapper.Map<TaskCategoriesVM>(taskCategories));
        }
    }
}
