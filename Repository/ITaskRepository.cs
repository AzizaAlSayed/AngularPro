using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.Repository
{
    public interface ITaskRepository
    {
        public IEnumerable<Tasks> GetAllTasks();
        public Tasks GetTask(int TaskId);
        public Tasks update(Tasks updatedTask);
        public Tasks CreateTask(Tasks Task);
        public Tasks Delete(int TaskId);
        
       
     
    }
}
