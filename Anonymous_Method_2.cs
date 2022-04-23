using System;

namespace ConsoleApp2
{
    public delegate string GreetingsDelegae(string name);
    public class Program
    { 
        static void Main(string[] args)
        {
            GreetingsDelegae gd = delegate (string name)
              {
                  return "Hello @" + name + " Welcome to my Repositry";
              };
            string GreetingsMessage = gd.Invoke("Bilal Shabbir");
            Console.WriteLine(GreetingsMessage);
            Console.ReadLine();
            
        }
    }
}

/*
 * Defination 
 * As of now, this is the approach we are following to bind a method
 * to a delegate and execute. An anonymous method is also related
 * to a delegate. Without binding a named block (function)
 * to a delegate, we can also bind a code block to a delegate 
 * means an unnamed code blocked to a delegate which is nothing
 * but an anonymous method in C#.
 * 
 * 
 * The anonymous methods can be defined using the delegate keyword
An anonymous method must be assigned to a delegate type.
This method can access outer variables or functions.
An anonymous method can be passed as a parameter.
This method can be used as event handler


 * */