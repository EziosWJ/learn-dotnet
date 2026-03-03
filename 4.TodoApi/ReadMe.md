# 

### 方案 1：使用位置式构造（推荐，简洁）
既然 record 支持位置参数，那就直接传：
```csharp
var todo = new Todo(nextId++, input.Title, false);
```
完整代码片段：
```csharp
app.MapPost("/todos", (TodoInput input) =>
{
    var todo = new Todo(nextId++, input.Title, false); // 👈 三个参数都传
    todos[todo.Id] = todo;
    return Results.Created($"/todos/{todo.Id}", todo);
});
```
✅ 这是最符合 record 设计哲学的写法。
### ✅ 方案 2：改用普通 class（如果你习惯 Java 风格）
如果你更喜欢像 Java 一样用 setter 或对象初始化器，可以不用 record：
```csharp
public class Todo
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}
```
然后就可以这样写：
```csharp
var todo = new Todo { Id = nextId++, Title = input.Title, IsCompleted = false };
```
💡 适合需要更多灵活性（比如 ORM 映射、无参构造）的场景。
✅ 方案 3：保留 record，但添加工厂方法（高级）
```csharp
record Todo(int Id, string Title, bool IsCompleted)
{
    public static Todo Create(string title, int id) => new(id, title, false);
}
````
调用：

```csharp
var todo = Todo.Create(input.Title, nextId++);
```