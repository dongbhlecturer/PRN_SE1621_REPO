using System;
using System.Linq;

string[] names = {"Dong","Nguyen Van A","Cong Phuong","Pack Hang Seo","Luc","Ha","Anh Minh","Anh Minh" };

/*1. Sap xep tang dan va in ra man hinh*/
//Array.Sort(names);
/*2. SortedSet */
/*3. LinQ format 1*/

var nameAsc = names.OrderBy(n => n.Length);
/*Lay ra tat cac cac name ma length > 5*/
var nameLength = names.Where(n => n.Length > 5);


/*4. LinQ format 2*/

var namesLin = from n in names
               where n.Length > 5 && n.Contains("M")
               select n;





foreach (string name in namesLin)
{
    Console.WriteLine(name);
}
