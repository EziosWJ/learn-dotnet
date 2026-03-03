# 快速开始

验证 SDK 安装 在终端中执行 `dotnet --version` 命令。如果返回版本号（例如 `8.0.x`），则表示 `.NET 8 SDK` 已正确安装。

确认项目结构 C# 代码通常需要项目文件支持。请检查 xxx\dotnet\0.hello\ 目录下是否存在 .csproj 文件。

若不存在，可在该目录运行 `dotnet new console` 初始化项目。
运行应用程序 在终端中进入 *.cs 所在目录，执行 `dotnet run` 命令。

验证输出 如果环境配置无误，终端将打印 `Hello, World!`，这是由代码中的 `Console.WriteLine` 方法输出的结果。