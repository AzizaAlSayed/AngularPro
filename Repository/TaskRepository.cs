using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskManagmentContext _context;

        public TaskRepository(TaskManagmentContext context)
        {
            _context = context;
        }

        public Tasks CreateTask(Tasks Task)
        {
            _context.Tasks.Add(Task);
            _context.SaveChanges();
            return Task;
        }

        public Tasks Delete(int TaskId)
        {
            Tasks task = _context.Tasks.Find(TaskId);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
            return task;
        }

        public IEnumerable<Tasks> GetAllTasks()
        {
            return _context.Tasks; 
        }

        public Tasks GetTask(int TaskId)
        {
            Tasks task = _context.Tasks.Find(TaskId);
            return task;
        }

        public Tasks update(Tasks Task)
        {
            _context.Tasks.Update(Task);
            _context.SaveChanges();
            return Task;
        }
    }
}
