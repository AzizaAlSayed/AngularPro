using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.Repository
{
    public interface ITaskCategoriesRepository
    {
        public TaskCategories GetTaskCategoryByTaskID(int TaskCategoryId);  
        public TaskCategories GetTaskCategoryByCarigoryID(int TaskCategoryId);
        public IEnumerable<TaskCategories> GetAllTasksCategories();
    }
}
