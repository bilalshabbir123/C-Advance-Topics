using System.Linq;
using System.Collections.Generic;
using System;

namespace ConsoleApp2
{
    public class Program
    { 
        static void Main(string[] args)
        {
            Employee[] emp =
                {
                new Employee {Name="Fraz",Salary=200000,Designation="London"},
                new Employee {Name="Bilal",Salary=100000,Designation="Lahore"},
                new Employee {Name="Ahmad",Salary=150000,Designation="Township"},
                new Employee{Name="Asad",Salary=120000,Designation="UK"},
            };
            //IEnumerable<string> empobj = from i in emp where i.Salary > 100000 orderby i.Salary select i.Name;
            IEnumerable<string> empobj = emp.Where(x => x.Salary > 100000).OrderBy(x => x.Name).Select(x => x.Name);
            foreach (string item in empobj)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Employee
    {
        public string Name;
        public int Salary;
        public string Designation;
    }
}

/*
 *LINQ stands for Language-Integrated Query and it is a powerful 
 *query language that was introduced with .Net 3.5 & Visual Studio 
 *2008. You can use LINQ with C# or VB to query different types 
 *of data sources such as SQL, XML, In memory objects, etc.

LINQ provides a simple but very effective way to manipulate data 
from different data sources such as database, XML file, or with 
a simple list of in-memory data. 
 */
