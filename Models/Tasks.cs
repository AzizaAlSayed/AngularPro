using System;
using System.Collections.Generic;

namespace AngularPro.Models
{
    public partial class Tasks
    {
        public int TaskId { get; set; }
        public string Subject { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public bool Completed { get; set; }
        public string Importance { get; set; }
    }
}
