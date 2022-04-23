using System;

namespace ConsoleApp2
{
    public delegate string GreetingsDelegae(string name);
    public class Program
    { 
        static void Main(string[] args)
        {
            GreetingsDelegae gd = (name)=>
              {
                  return "Hello @" + name + " Welcome to my Repositry";
              };
            string GreetingsMessage = gd.Invoke("Bilal Shabbir");
            Console.WriteLine(GreetingsMessage);
            
        }
    }
}

/*
 * Defination 
 * The Lamda Expression in C# is the shorthand for writing the anonynmous 
 * function. So we can say that the Lamda Expression in C# is noting but
 * to simplify the anonymous fucntion in C#.
 * 
 * Questions: Two things come to our minds.
As the Anonymous method is used for lesser writing, 
then why we used the delegate keyword. As the delegate knows about 
the return type and parameter type it accepts, 
then why we explicitly specifying the parameter type the delegate
accepts.


To create a lambda expression in C#, we need to specify the input 
parameters (if any) on the left side of the lambda operator =>, and 
we need to put the expression or statement block on the other side.



 * 
 * 
 * Lamda Expression is nothing just modify the Delegate--To--Anonymous Method--Lamda Expression.
 * 
 *Simply removing the keyword delegate and type of parameter
 * */