using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.Repository
{
    public class TasksCategoriesRepository : ITaskCategoriesRepository
    {
        masterContext _context;
        Tasks _task;
        Categories _category;


        public TasksCategoriesRepository(masterContext context)
        {
            _context = context;
        }

        public IEnumerable<TaskCategories> GetAllTasksCategories()
        {
            throw new NotImplementedException();
        }

        public TaskCategories GetTaskCategoryByCarigoryID(int TaskCategoryId)
        {
            TaskCategories taskCategory = _context.TaskCategories.Find(_task.TaskId);
            return taskCategory;
        }

        public TaskCategories GetTaskCategoryByTaskID(int TaskCategoryId)
        {
            TaskCategories taskCategory = _context.TaskCategories.Find(_category.CategoryId);
            return taskCategory;
        }
    }
}
