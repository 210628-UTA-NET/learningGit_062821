using System; // Importing System namespace
using HouseFunction;

/*
Naming conventions in C#
    - We use PascalCase for most naming conventions (capitalize first letter, and every new word after)
    - We use camelCase for naming fields
*/

namespace HelloWord
{
    class Program
    {
        // We can use underscores for private fields to reference them easier in our code
        private static string _first = "Hello";
        private static string _last = "World";

        // Main method is the first method that will be called/run whenever you command "dotnet run"
        // static means you dont have to instantiate the program class to use the method
        // void means the method will not return anything
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test obj = new Test(); // Will instantiate the Test class
            obj.SomeMethod();

            Console.WriteLine(_first + _last);
            Console.WriteLine(obj.SomeMethod());

            // House example
            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("Blue");
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 8000;
            Console.WriteLine(objHouse.Price);
            objHouse.Name = "Satyam's House";
            Console.WriteLine(objHouse.Name);
        }
    }

    class Test
    {
        public string SomeMethod()
        {
            //Console.WriteLine("Something was called.");

            // return keyword will 
            return "Hello Hello Something World";
        }
    }
}
