using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Core.Models;

public class WorkTask : TaskBase
{
    public string Project { get; set; } = "";

    // TODO:
    // Override GetTypeName() returnerer "Work"

    // TODO:
    // Override Describe() saa Project ogsaa naevnes
}