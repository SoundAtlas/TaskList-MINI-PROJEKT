using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Core.Models
{
    public interface ITask
    {
        int Id { get; set; }
        string Title { get; set; }
        bool IsDone { get; set; }
    }
}
