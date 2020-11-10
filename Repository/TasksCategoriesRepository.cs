using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.Repository
{
    public class TasksCategoriesRepository : ITasksCategoriesRepository
    {
        private readonly  TaskManagmentContext _context;
       
        public TasksCategoriesRepository(TaskManagmentContext context)
        {
            _context = context;
        }

        public TasksCategories Create(TasksCategories TaskCategory)
        {
            _context.TasksCategories.Add(TaskCategory);
            _context.SaveChanges();
            return TaskCategory;
        }

        public TasksCategories Delete(int TaskCategoryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TasksCategories> GetAllTasksCategories()
        {
            return _context.TasksCategories;

        }

        public TasksCategories GetTaskCategoryByCarigoryID(int TaskCategoryId)
        {
            TasksCategories taskCategory = _context.TasksCategories.Find(TaskCategoryId);
            return taskCategory;
        }

        public TasksCategories GetTaskCategoryByTaskID(int TaskCategoryId)
        {
            TasksCategories taskCategory = _context.TasksCategories.Find(TaskCategoryId);
            return taskCategory;
        }

        public TasksCategories Update(TasksCategories TaskCategory)
        {
            throw new NotImplementedException();
        }
    }
}
