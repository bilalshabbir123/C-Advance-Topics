using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }


    public class Program
    { 
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Bilal",
                Gender = "Male",
                Salary = 5000
            };Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Ahsan",
                Gender = "Male",
                Salary = 5000
            };Employee emp3 = new Employee()
            {
                ID = 104,
                Name = "Bilal",
                Gender = "Ahmad",
                Salary = 5000
            };Employee emp4 = new Employee()
            {
                ID = 101,
                Name = "Ahsaan",
                Gender = "Male",
                Salary = 5000
            };

            // Creating list of Employees
            List<Employee> listEmployess = new List<Employee>();
            listEmployess.Add(emp1);
            listEmployess.Add(emp2);
            listEmployess.Add(emp3);
            listEmployess.Add(emp4);
            
            // We can retrieve the Items from a list collection by using index. 
            // The following line of code will retrieve the employee from the list. 
            // The List index is also 0 based.

            Employee emp = listEmployess[0];
            Console.WriteLine("Retrive the First employee by index");
            Console.WriteLine("ID ={0}  Name={1}  Gender={2}  Salary={3}",emp.ID,emp.Name,emp.Gender,emp.Salary);
            Console.WriteLine();

            // retrieving the list using foreach loop
            Console.WriteLine("Retriving the list using foreach loop");
            foreach(Employee e in listEmployess)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
                        e.ID, e.Name, e.Gender, e.Salary);
            }
        }
    }
}

/*
*The Generic List in C# is a collection class that is present in System.Collections.Generic namespace. The List Collection class is one of the most widely used generic collection classes in real-time applications. This Generic List collection class represents a strongly typed list of objects which can be accessed by using the index. It also provides methods that can be used for search, sort and manipulate the list items.
*
*
*
*Add(T value): This method is used to add an item to the end of the list collection.
Remove(T value): This method is used to remove the first occurrence of a specific item from the collection.
RemoveAt(int index): This method takes the index position of the elements and then removes that element from the collection.
Insert(int index, T value): This method is used to inserts an element into the collection at a specified index position.
Capacity: This property is used to return the capacity of the collection means how many elements you can insert into the collection.
*
 */
