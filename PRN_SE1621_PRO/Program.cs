using System;
namespace Fptedu.Prn1621;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"==================================");
        int a = 10, b = 20; //argruments
        //Console.WriteLine("Total of a = {0} and b= {1} is {2}",a,b, Sum(a,b));
        Console.WriteLine($"Total of a = {a} and b = {b} is: {Sum(a,b)}"); //String Interpolation
        //Console.WriteLine(args[0]);

        Console.ReadLine();
    }
    //manual methods: parameters
    /*
        multi-lines
     */
    public static int Sum(int x, int y)
    {
        return x + y;
    }
}
