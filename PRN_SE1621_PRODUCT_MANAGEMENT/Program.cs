﻿namespace Prn.Se1621;
using static System.Console;

public class Program
{
    public static void Main()
    {
        Product p = new Product();
        p.Id = 1;
        p.ProductName = "Laptop Dell";
        p.Desc = "San pham moi nhat 2022";
        p.UnitPrice = 1500;
        p.StartDate = DateTime.Now;//current date



        WriteLine(p);
        ReadLine(); 
    }
}


