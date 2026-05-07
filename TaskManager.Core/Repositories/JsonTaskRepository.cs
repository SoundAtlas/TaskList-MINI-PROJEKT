using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using TaskManager.Core.Exceptions;
using TaskManager.Core.Models;

namespace TaskManager.Core.Repositories;

public class JsonTaskRepository : ITaskRepository
{
    private readonly string filePath;

    private List<TaskBase> tasks = new();

    private static readonly JsonSerializerOptions options = new()
    {
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public JsonTaskRepository(string filePath)
    {
        this.filePath = filePath;

        Load();
    }


    public void Add(TaskBase task)
    {
        task.Id = tasks.Count + 1;
        tasks.Add(task);
    }

    public bool Remove(int id)
    {
        TaskBase task = GetById(id);
        task.Remove(task);
        return true;
    }

    public TaskBase GetById(int id)
    {
        foreach (TaskBase task in tasks)
        {
            if (task.Id == id)
            {
                return task;
            }
        }

        throw new TaskNotFoundException(id);
    }

    public IEnumerable<TaskBase> GetAll()
    {
        return tasks;
    }

    public void MarkDone(int id)
    {
        TaskBase task = GetById(id);
        task.IsDone = true;
    }

    public void Save()
    {
        string json = JsonSerializer.Serialize(tasks, options);
        File.WriteAllText(filePath, json);
    }


    public void Load()
    {
        if (!File.Exists(filePath))
        {
            tasks = new List<TaskBase>();
            return;
        }

        try
        {
            string json = File.ReadAllText(filePath);
            tasks = JsonSerializer.Deserialize<List<TaskBase>>(json, options) ?? new List<TaskBase>();
        }
        catch (JsonException)
        {
            tasks = new List<TaskBase>();
        }
    }

    private int GetNextId()
    {
        return tasks.Count == 0 ? 1 : tasks.Max(task => task.Id) + 1;
    }
