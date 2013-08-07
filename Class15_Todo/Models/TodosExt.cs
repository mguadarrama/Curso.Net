using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Class15_Todo.Models
{
    public partial class Todo
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public bool Completed { get; set; }
    }
}