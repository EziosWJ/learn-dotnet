using System.Text.Json;
using System.Text.Encodings.Web;
using wpkg;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var person = new Person("张三", 18, "zhangsan@qq.com");
Console.WriteLine(person);
string value = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });

File.WriteAllText("person.json", value);

Console.WriteLine("person.json写入完毕");


var person2 = JsonSerializer.Deserialize<Person>(File.ReadAllText("person.json"));
Console.WriteLine(person2);
Console.WriteLine(person == person2);
Console.WriteLine(person.Equals(person2));
Console.WriteLine(person.GetHashCode() == person2.GetHashCode());
