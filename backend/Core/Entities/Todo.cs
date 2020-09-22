using System;
using System.Collections.Generic;
using System.Text;

namespace Todo.Core.Entities
{
    public class Todo
    {
        public string Title;
        public string Description;

        public bool IsCompleted;
        public DateTime StartDate;
        public DateTime DeadlineDate;
        public DateTime CompletionDate;
    }
}
