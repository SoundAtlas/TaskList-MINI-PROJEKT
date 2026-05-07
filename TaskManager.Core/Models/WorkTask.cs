using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Core.Models;

namespace TaskManger.Core.Models;

public class WorkTask : TaskBase
{
    public string Project { get; set; } = "";

    public override string GetTypeName()
    {
        return "Work";
    }


    public override string Describe()
    {
        return $"{base.Describe()} - Project: {Project}";
    }
}