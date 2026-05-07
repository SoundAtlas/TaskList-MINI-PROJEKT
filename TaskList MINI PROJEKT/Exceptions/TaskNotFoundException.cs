using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Core.Exceptions;

public class TaskNotFoundException : Exception
{
    public int TaskId { get; }

    public TaskNotFoundException(int taskId)
        : base($"Opgave med Id {taskId} blev ikke fundet")
    {
        TaskId = taskId;
    }
}