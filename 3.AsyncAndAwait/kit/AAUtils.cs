namespace wpkg
{
    
    public class AAUtils
    {
        public async static Task UseAsync()
        {
            Console.WriteLine("Async Task Start");
            Thread.Sleep(5000);
            Console.WriteLine("Async Task End");
        }
    }
}