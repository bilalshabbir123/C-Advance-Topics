using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    { 
        static void Main(string[] args)
        {
            //Createing an interger list
            //it is going to store only integer value
            List<int> integerList = new List<int>();
            Console.WriteLine("Initial Capacity:  "+integerList.Capacity);
            integerList.Add(10);
            Console.WriteLine("Capacity after adding first item: "+integerList.Capacity);
            integerList.Add(20);
            integerList.Add(30);
            integerList.Add(40);
            Console.WriteLine("Capacity after adding fourth item: "+integerList.Capacity);
            integerList.Add(60);
            Console.WriteLine("Capacity after 5th element: "+integerList.Capacity);

            // Printing the List items using foreach loop
            Console.WriteLine("Printing the List items using for Loop:");
            foreach (var item in integerList)
            {
                Console.WriteLine(item);
            }

            // Removing the values from the middle of the list
            //here we are removing by value
            integerList.Remove(30);
            //You can also remove element by using index position
            //integerList.RemoveAt(2);
            //Printing the list items using foreach loop after
            //removing an element from the collection
            Console.WriteLine("List items after removing the value 30 :");
            foreach (var item in integerList)
            {
                Console.WriteLine(item);
            }
            //inserting values into the middle of the list collection
            integerList.Insert(2, 25);
            Console.WriteLine("List items after inserting the value 25 in teh index 2:");
            foreach (var item in integerList)
            {
                Console.WriteLine(item+ "  ");
            }
            Console.ReadKey();
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
