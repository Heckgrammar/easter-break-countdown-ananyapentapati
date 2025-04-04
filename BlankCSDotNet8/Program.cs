using System.Text;

namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            DateTime target = new DateTime(2025, 4, 4, 15, 15, 0);
            TimeSpan difference = target - current;

            Console.WriteLine(current);
            Console.WriteLine(target);
            Console.WriteLine(difference);      // 7th of spetember is humnas birthday 
            Thread.Sleep(1000);                 // 22nd of december is pareens birthday 


        }
    }
}
