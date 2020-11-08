using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly ITaskCategoriesRepository _taskCategoriesRepository;
        private readonly IMapper _mapper;

        [HttpGet]
        public IActionResult index()
        {
           
            var taskCategory = _taskCategoriesRepository.GetAllTasksCategories();
            return Ok(_mapper.Map<IEnumerable<TaskCategoriesVM>>(taskCategory));
        }

        [HttpGet]
        public IActionResult GetTaskCategoryByTaskID(int TaskID)
        {
            var taskCategory = _taskCategoriesRepository.GetTaskCategoryByTaskID(TaskID);
            return Ok(_mapper.Map<TaskCategoriesVM>(taskCategory));

        }

        [HttpGet]
        public IActionResult GetTaskCategoryByCategoryID(int CategoryID)
        {
            var taskCategory = _taskCategoriesRepository.GetTaskCategoryByCarigoryID(CategoryID);
            return Ok(_mapper.Map<TaskCategoriesVM>(taskCategory));

        }
    }
}
