using static System.Console;
namespace Prn.Se1629;

public class Program
{
    public static void Main()
    {
        //dong bo
        /*
        PrintNumber();
        WriteLine("=============================");
        PrintNumber();
        WriteLine("=============================");
        PrintNumber();
        */

        //Tao ra 3 threads, moi thread thuc thu loi goi PrintNumber
        
        for (int i = 1; i <= 5; i++)
        {
            Thread t = new Thread(() => 
                PrintNumber(i)
            );
            t.Start();
        }
        
    }

    public static void PrintNumber(int thread)
    {
        for (int i = 1; i <=5; i++)
        {
            Thread.Sleep(1000);
            WriteLine($"Thread: {thread} - {i}");
        }
    }
}