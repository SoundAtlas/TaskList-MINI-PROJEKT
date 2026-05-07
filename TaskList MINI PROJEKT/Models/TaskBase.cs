namespace TaskManager.Core.Models;

public abstract class TaskBase : ITask
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public bool IsDone { get; set; }

    // TODO:
    // Tilfoej abstract metode GetTypeName() der returnerer string

    // TODO:
    // Tilfoej virtual metode Describe() der returnerer:
    // "{GetTypeName()} #{Id}: {Title} [{(IsDone ? "x" : " ")}]"
}