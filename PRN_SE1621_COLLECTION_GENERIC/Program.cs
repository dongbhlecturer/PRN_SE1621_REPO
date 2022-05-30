using System.Collections;
using System.Collections.Generic;
using Prn.Se1621;

List<Employee> list = new List<Employee>(); 
list.Add(new Employee(1,"Dong",1344.5d));
list.Add(new Employee(1, "Dong", 1344.5d));
list.Add(new Employee(2, "Hai", 124.5d));
list.Add(new Employee(3, "Nguyen Cong Phuong", 1524.5d));
list.Add(new Employee(4, "Pack Hang Seo", 324.5d));
list.Add(new Employee(5, "Tran Van Cao", 1524.5d));
list.Add(new Employee(6, "Ma Van Meo", 19824.5d));

Console.WriteLine($"Number of Employee in List: {list.Capacity}");
foreach (Employee e in list)
{
    
    Console.WriteLine(e);
}
/*SortedSet*/
SortedSet<Employee> set = new SortedSet<Employee>();
set.Add(new Employee(1, "Dong", 1344.5d));
set.Add(new Employee(1, "ABC", 134d));
set.Add(new Employee(2, "Hai", 124.5d));
set.Add(new Employee(3, "Nguyen Cong Phuong", 1524.5d));
set.Add(new Employee(4, "Pack Hang Seo", 324.5d));
set.Add(new Employee(5, "Tran Van Cao", 1524.5d));
set.Add(new Employee(6, "Ma Van Meo", 19824.5d));

Console.WriteLine("==========================");
foreach (Employee e in set)
{

    Console.WriteLine(e);
}



