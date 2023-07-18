using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.WriteLine($"{name} is ready to learn C#");
            const int num1 = 17;
            int num2 = 32;
            int x=7, y=42, z=99;
            Console.WriteLine(num1+num2); //print value of num1+num2
            Console.WriteLine(y-x+z);
            // Data Types
            // int myNum = 5; // Interger (whole number) Use L for long numbers 150000000000L
            // double myDoubleNum = 5.99D; // Floating point number use F for float and D for Double number
            // char myLetter = 'M'; // Character
            // bool myBool = true // Boolean lowercase
            // string myText = "String"; // String
            
            // implicit Casting
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            
            // Explicit Casting
            double aDouble= 9.78;
            int intTwo = (int)aDouble;
            Console.WriteLine(aDouble);
            Console.WriteLine(intTwo);

            // Type Conversion Methods
            int twoInt = 10;
            double twoDouble = 5.25;
            bool boolTwo = true;

            Console.WriteLine(Convert.ToString(twoInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(twoInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(twoDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(boolTwo));   // convert bool to string

            // write code above this line in order to not have to start over (Practice Comment)
            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}