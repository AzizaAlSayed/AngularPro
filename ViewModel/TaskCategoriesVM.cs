using AngularPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPro.ViewModel
{
    public class TaskCategoriesVM
    {
        public int CategoryId { get; set; }
        public int TaskId { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Tasks Task { get; set; }
    }
}
