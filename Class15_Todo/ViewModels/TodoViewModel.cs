using Class15_Todo.Models;
using System.Collections.Generic;

namespace Class15_Todo.ViewModels
{
    public class TodoViewModel
    {
        public List<Todo> TodoList { get; set; }
        public Todo TodoNew { get; set; }
    }
}