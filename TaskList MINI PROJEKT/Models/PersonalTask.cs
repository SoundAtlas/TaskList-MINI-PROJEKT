using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Core.Models;

public class PersonalTask : TaskBase
{
    public string Category { get; set; } = "";

    // TODO:
    // Override GetTypeName() returnerer "Personal"

    // TODO:
    // Override Describe() saa Category ogsaa naevnes
}