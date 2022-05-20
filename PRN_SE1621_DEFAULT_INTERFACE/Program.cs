
namespace PRN.SE1621.DEFAULT_INTERFACE;
using System.Collections;
using static System.Console;
/*define interface*/

public interface ISample
{
   static void Print()
   {
        WriteLine($"Hello .NET C# 10");
   }
    string GetString(string s)
    {
        return "Welcome " + s;
    }
    void Display();
}

public interface ISecond
{
    string GetString(string s)
    {
        return "Goodmorning " + s;
    }
}

public class MySecond : ISecond
{

}
public class MySample : ISample
{

    public void Display()
    {
        WriteLine($" Hi !");
    }
}


public class MyClass
{
    public static int x = 1;
    static MyClass()
    {
        x = 2;
        WriteLine($"Static constructor {x}");
    }

    public MyClass()
    {
        x++; //x=x+1;
        WriteLine($"public constructor {x}");
    }

}


public class Program
{
    public static void Main()
    {
        /*
        MySample obj = new MySample(); //instance (hien thuc cua class MySample
        obj.Display();
        

        ISample.Print();
      
        ISample s = obj;
        string str = s.GetString("Dong");
        WriteLine(str);

        ISecond a = new MySecond();
        str = a.GetString("abc");
        WriteLine(str);

        */
        MyClass m1 = new MyClass();
        MyClass.x = 4;
        MyClass m2 = new MyClass();
        ReadLine();
        

        
    }
}