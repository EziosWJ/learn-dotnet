using System;
using System.Management;

class Program
{
    static void Main()
    {
        // 查询所有 PnP 设备，且 DeviceID 以 "USB\\" 开头
        string query = "SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE 'USB\\\\%'";

        using var searcher = new ManagementObjectSearcher(query);
        foreach (ManagementObject device in searcher.Get())
        {
            string name = device["Name"]?.ToString() ?? "Unknown";
            string deviceId = device["DeviceID"]?.ToString() ?? "";
            string pnpClass = device["PNPClass"]?.ToString() ?? "";

            Console.WriteLine($"名称: {name}");
            Console.WriteLine($"设备ID: {deviceId}");
            Console.WriteLine($"类型: {pnpClass}");
            Console.WriteLine(new string('-', 40));
        }
    }
}