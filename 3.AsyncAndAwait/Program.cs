using wpkg;

public class Program
{
    public static async Task Main(string[] args)
    {
        Task.Run(() =>
        {
            AAUtils.UseAsync();
        });
        Task.Run(() =>
        {
            AAUtils.UseAsync();
        });
        await AAUtils.UseAsync();
        Console.WriteLine("Main Task End");

    }
}
