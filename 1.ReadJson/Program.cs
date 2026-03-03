using System.Text.Json;

// 读取 JSON 文件
string json = File.ReadAllText("person.json");
Person person = JsonSerializer.Deserialize<Person>(json)!;


Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Age: {person.Age}");
Console.WriteLine($"Email: {person.Email}");
// 在 C# 顶级语句中，类型声明必须位于所有可执行语句之后
// 定义类（或用 record）
record Person(string Name, int Age, string Email);