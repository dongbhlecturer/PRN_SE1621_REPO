namespace Prn.Threading;
public class Program
{
    public static void Main()
    {
        Printer p = new Printer();

        //1. Gia su minh co 1 lop Printer co 1 ham la print so tu 1 - 5
        /*
        p.PrintNumbers('a');
        Console.WriteLine("===================");
        p.PrintNumbers('b');
        Console.WriteLine("===================");
        p.PrintNumbers('c');
        */

        //2. tao ra 3 luong to print the numbers from 1 to 5 
        Thread[] arrThreads = new Thread[5];
        
        arrThreads[0] = new Thread(() => p.PrintNumbers('a'));
        arrThreads[1] = new Thread(() => p.PrintNumbers('b'));
        arrThreads[2] = new Thread(() => p.PrintNumbers('c'));
        arrThreads[3] = new Thread(() => p.PrintNumbers('d'));
        arrThreads[4] = new Thread(() => p.PrintNumbers('e'));

        for(int i = 0; i < arrThreads.Length; i++)
        {
            arrThreads[i].Start();
        }

        Console.ReadLine();

    }

}
