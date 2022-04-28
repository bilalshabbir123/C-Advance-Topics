using System.Linq;
using System.Collections.Generic;
using System;

namespace ConsoleApp2
{
    public class Program
    { 
        static void Main(string[] args)
        {
            List<Employees> employees=new List<Employees> {
                new Employees() { Name = "Fraz", Salary = 200000, Designation = "London" },
                new Employees() { Name = "Bilal", Salary = 100000, Designation = "Lahore" },
                new Employees { Name = "Ahmad", Salary = 150000, Designation = "Township" },
                new Employees { Name = "Asad", Salary = 120000, Designation = "UK" } 
            
            };
            //IEnumerable<string> empobj = from i in emp where i.Salary > 100000 orderby i.Salary select i.Name;
            var Query = (from obj in employees select obj).ToList();

            foreach (var item in Query)
            {
                Console.WriteLine($"Name= {item.Name},Salary= {item.Salary},Designation={item.Designation}");
            }
            Console.WriteLine("--------------------");
            //Method syntax
            var basicMethod = employees.ToList();
            foreach (var item in basicMethod)
            {
                Console.WriteLine($"Name= {item.Name},Salary= {item.Salary},Designation={item.Designation}");
            }

            Console.WriteLine("--------------------");
            //Method syntax select query
            var basicMethod1 = employees.Select(x => x.Name).ToList();
            foreach (var item in basicMethod1)
            {
                Console.WriteLine(item);
            }

            //Now we fetching only Name and Salary
            var selectQuery = (from emp in employees
                               select new Employees()
                               { Name = emp.Name, Salary = emp.Salary }).ToList();
            foreach (var item in selectQuery)
            {
                Console.WriteLine($"Name= { item.Name},Salary={item.Salary}");
            }
        }
    }
    class Employees
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

IEnumerable and IQueryable are the two most interfaces used frequently in almost all these queries.

Operators are set of methods which are used in LINQ to write a query.

These methods offers lots of features which can be applied on data.

For Example--
*Filtering data (Filter the data)
*Sorting(Order of data)
*Etc.. 
*
*
*Projection is used to select data from a data source and creating a new form of data.
*
*We cam select the original data in its original state also in other 
*from by applying some operations on it.

 */
