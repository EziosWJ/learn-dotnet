# 创建项目

1. 创建项目目录并初始化 在终端中执行以下命令创建新的控制台项目：

```bash
dotnet new console -n 1.ReadJson -o 1.ReadJson --framework net8.0
```
2. 锁定 SDK 版本 进入新项目目录，创建 global.json 文件以确保使用 .NET 8 SDK：

```bash
cd 1.ReadJson
dotnet new globaljson --sdk-version 8.0.418
```
3. 验证项目结构 创建完成后，项目目录应包含以下文件：

```bash
1.ReadJson/
├── 1.ReadJson.csproj
├── Program.cs
├── global.json
└── obj/
```
运行测试 执行以下命令验证项目是否正常：

```bash
dotnet run
```