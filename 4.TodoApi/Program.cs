// Program.cs
using System.Collections.Concurrent;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 模拟数据库（内存存储）
var todos = new ConcurrentDictionary<int, Todo>();
int nextId = 1;

// GET /todos
app.MapGet("/todos", () => todos.Values);

// POST /todos
app.MapPost("/todos", (TodoInput input) =>
{
    var todo = new Todo ( nextId++, input.Title, false );
    todos[todo.Id] = todo;
    return Results.Created($"/todos/{todo.Id}", todo); // 201 Created
});

// DELETE /todos/{id}
app.MapDelete("/todos/{id}", (int id) =>
{
    if (todos.Remove(id, out _))
        return Results.Ok(); // 200
    return Results.NotFound(); // 404
});

app.Run();

// 数据模型
record Todo(int Id, string Title, bool IsCompleted);
record TodoInput(string Title);