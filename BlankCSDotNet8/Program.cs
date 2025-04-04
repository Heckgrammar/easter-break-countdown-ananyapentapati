using System.Text;

namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            while (true) 
            {
                DateTime current = DateTime.Now;
                DateTime target = new DateTime(2025, 4, 4, 15, 15, 0);
                TimeSpan difference = target - current;
                Console.WriteLine(difference);
                Thread.Sleep(1000);
            }
        }
    }
}
