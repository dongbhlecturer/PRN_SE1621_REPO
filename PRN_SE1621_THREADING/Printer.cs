namespace Prn.Threading;
using static System.Console;
public class Printer
{
    //private object threadLock = new object();
    public void PrintNumbers(char c)
    {
        //lock (threadLock)
            try
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is excuting PrintNumber");
                for (int i = 1; i <= 5; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(500 * r.Next(5));
                    Write($"{i,3}{(i == 5 ? "" : ",")}");
                }
                Console.WriteLine();

            }
            catch ( Exception ex){
                Console.WriteLine(ex.Message);
            }
        
    }
}
