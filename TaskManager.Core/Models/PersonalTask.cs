using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Core.Models;

public class PersonalTask : TaskBase
{
    public string Category { get; set; } = "";

    public override string GetTypeName()
    {
        return "Personal";
    }

    public override string Describe()
    {
        return $"{base.Describe()} - Category: {Category}";
    }
}