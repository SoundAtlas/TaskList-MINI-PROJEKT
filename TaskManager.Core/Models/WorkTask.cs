namespace TaskManager.Core.Models;

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