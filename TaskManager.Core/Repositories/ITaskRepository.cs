using System;
using System.Collections.Generic;
using System.Text;

using TaskManager.Core.Models;

namespace TaskManager.Core.Repositories;

public interface ITaskRepository
{
    void Add(TaskBase task);

    bool Remove(int id);

    TaskBase GetById(int id);
    // smider TaskNotFoundException

    IEnumerable<TaskBase> GetAll();

    void MarkDone(int id);

    void Save();

    void Load();
}