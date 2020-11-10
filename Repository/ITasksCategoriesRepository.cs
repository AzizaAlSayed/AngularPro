using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.Repository
{
    public interface ITasksCategoriesRepository
    {
        public TasksCategories GetTaskCategoryByTaskID(int TaskCategoryId);  
        public TasksCategories GetTaskCategoryByCarigoryID(int TaskCategoryId);
        public IEnumerable<TasksCategories> GetAllTasksCategories();
        public TasksCategories Update(TasksCategories TaskCategory);
        public TasksCategories Create(TasksCategories TaskCategory);
        public TasksCategories Delete(int TaskCategoryId);

    }
}
