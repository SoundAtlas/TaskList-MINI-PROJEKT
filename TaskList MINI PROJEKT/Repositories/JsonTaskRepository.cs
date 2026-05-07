using System;
using System.Collections.Generic;
using System.Text;

using System.Text.Json;
using System.Text.Json.Serialization;

using TaskManager.Core.Models;
using TaskManager.Core.Exceptions;

namespace TaskManager.Core.Repositories;

public class JsonTaskRepository : ITaskRepository
{
    private readonly string filePath;

    private List<TaskBase> tasks = new();

    private static readonly JsonSerializerOptions options = new()
    {
        WriteIndented = true,

        // Hint:
        // brug JsonDerivedType-attribut paa TaskBase eller en converter
        // til at haandtere arv ved (de)serialisering
    };

    public JsonTaskRepository(string filePath)
    {
        this.filePath = filePath;

        Load();
    }

    // TODO:
    // Implementer alle interface-metoder

    // TODO:
    // GetById og MarkDone skal smide TaskNotFoundException
    // hvis Id ikke findes

    // TODO:
    // Load skal haandtere at filen ikke findes
    // og at JSON er korrupt
}