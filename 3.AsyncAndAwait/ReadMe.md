# 

### 错误 1：使用 .Result 或 .Wait()（会导致死锁！）

```csharp
// 千万别这么写！
string data = DownloadDataAsync().Result; // 可能死锁（尤其在 ASP.NET 上下文）
```

### 错误 2：async void（仅用于事件处理器）

```csharp
// 危险！异常无法捕获，程序可能崩溃
public async void BadMethod() { ... }
```
✅ 正确做法：返回 Task
```csharp
public async Task GoodMethod() { ... }
```
✅ 最佳实践 1：I/O 操作一律用 Async
```shell
File.ReadAllTextAsync
HttpClient.GetAsync
DbContext.SaveChangesAsync（EF Core）
Console.Out.WriteLineAsync
```
💡 CPU 密集型任务？用 Task.Run 包装（但 Web 应用中尽量避免）
✅ 最佳实践 2：并行执行多个异步操作
```csharp
var tasks = new[]
{
    FetchUserAsync(1),
    FetchUserAsync(2),
    FetchUserAsync(3)
};

var users = await Task.WhenAll(tasks); // 等待全部完成
```