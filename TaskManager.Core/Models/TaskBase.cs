namespace TaskManager.Core.Models;


/*[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(WorkTask), "work")]
[JsonDerivedType(typeof(PersonalTask), "personal")]*/
public abstract class TaskBase : ITask
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public bool IsDone { get; set; }

    public abstract string GetTypeName();
    public virtual string Describe()
    {
        return $"{GetTypeName()} #{Id}: {Title} [{(IsDone ? "x" : " ")}]";
    }
}
