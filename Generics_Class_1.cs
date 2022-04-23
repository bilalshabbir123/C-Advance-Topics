using System;

namespace ConsoleApp2
{
    //My GenericClass is a Generic Class
    class MyGenericClass<T>
    {
        //Generic variable 
        //The data type is Generic
        private T genericmMemberVariable;

        //Generic Constructor
        //Constructor accepts one parameter of Generic type

        public MyGenericClass(T value)
        {
            genericmMemberVariable = value;
        }

        //Generic Method
        //Method accepts one Generic type Parameter
        //Method return type also Generic
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type:{0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type:{0}, value:{1}",typeof(T).ToString(), genericmMemberVariable);
            return genericmMemberVariable;
        }

        // Generic Property 
        // The data type is generic

        public T genericProperty { get; set; }
    }
    public class Program
    { 
        static void Main(string[] args)
        {
            MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(10);
            int val = integerGenericClass.genericMethod(200);
            Console.ReadKey();
        }
    }
}

/*
 * Defination 
 * Generics in C# are introduced as part of C# 2.0. The Generics in C# allows us to define classes and methods
 * which are decoupled from the data type. In other words, we can say that the Generics allow us to create classes using angular
 * brackets for the data type of its members. 
 * At compilation time, these angular brackets are going to be replaced with some specific data types.
 * 
 * Advantages of Generics in C#
--It Increases the reusability of the code.
--The Generics are type-safe. We will get the compile-time error if we try to use a different type
of data rather than the one we specified in the definition.
--We get better performance with Generics as it removes the possibilities of boxing and unboxing.


 */
