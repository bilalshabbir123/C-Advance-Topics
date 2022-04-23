using System;

namespace ConsoleApp2
{
    public delegate string GreetingsDelegae(string name);
    public class Program
    {
        public static string Greetings(string name)
        {
            return "Hello @ " + name + " Welcome to my Github Repositry";
        }
        static void Main(string[] args)
        {
            GreetingsDelegae gd = new GreetingsDelegae(Program.Greetings);
            string GreetingsMessage = gd.Invoke("Bilal Shabbir");
            Console.WriteLine(GreetingsMessage);
        }
    }
}

/*
 * Defination 
 * An anonymous method in c# is a method with out having a name.
 * The anonymous method in c# can be defined using the keyword delegate
 * and can assigned of the delegate type.
 * 
 *          Why we need Anonymous method in C#
 *In our Delegates in c# we discusse how
 *To bind a delegate with a method, first, we need to create an instance 
 *of a delegate and when we create the instance of a delegate, 
 *we need to pass the method name as a parameter to the delegate constructor
 * and it is the function the delegate will point to.          
 * 
 * 
 * In the above example,
1.	We create one delegate (GreetingsDelegate)
2.	Then we instantiate the delegate, while we are instantiating the delegate
 we are passing the Method name as a parameter to the constructor of the delegate


3.	Finally, we invoke the delegate
As of now, this is the approach we are following to bind a method to a delegate and execute. 
An anonymous method is also related to a delegate. Without binding a named block (function) to a delegate,
we can also bind a code block to a delegate means an unnamed code blocked to a delegate
which is nothing but an anonymous method in C#.



*/