using System.Drawing;
using System;

namespace _3B_PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 3B Practice Problems");
            bool continueExecution = true;
            while (continueExecution)
            {
                Console.WriteLine("Please choose any one of the following program:");
                Console.WriteLine("1.Types of Constructor\n2.Interface Concept\n3.Access Modifier \n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        // Using the default constructor
                        Constructor C = new Constructor();
                        Console.WriteLine("Default Constructor:");
                        C.Display();

                        // Using the parameterized constructor
                        Constructor C1 = new Constructor("Ganesh", 23);
                        Console.WriteLine("\nParameterized Constructor:");
                        C1.Display();

                        // Using the copy constructor
                        Constructor C2 = new Constructor(C1);
                        Console.WriteLine("\nCopy Constructor:");
                        C2.Display();
                        break;

                    case 2:
                        Triangle T = new Triangle(5);
                        Rectangle R = new Rectangle(4, 6);

                        Console.WriteLine($"Circle - Area: {T.CalculateArea()}, Perimeter: {T.CalculatePerimeter()}");
                        Console.WriteLine($"Rectangle - Area: {R.CalculateArea()}, Perimeter: {R.CalculatePerimeter()}");
                        break;

                    case 3:
                        Access_Modifiers A_M = new Access_Modifiers();
                        Console.WriteLine($"PublicField from Main: {A_M.PublicField}");
                        // PrivateField is not accessible from Main
                        // ProtectedField is not accessible from Main
                        Console.WriteLine($"InternalField from Main: {A_M.InternalField}");

                        // PublicMethod is accessible from Main
                        A_M.PublicMethod();
                        // PrivateMethod is not accessible from Main
                        // ProtectedMethod is not accessible from Main
                        A_M.InternalMethod();

                        Console.WriteLine("\nDerived class:");
                        MyDerivedClass derivedObj = new MyDerivedClass();
                        derivedObj.AccessBaseClassMembers();
                        break;

                    default:
                        Console.WriteLine("Invalid option, Please select a valid program.");
                        break;
                }

                Console.WriteLine("Do you want to continue?(yes or no)");
                string userInput = Console.ReadLine().ToLower();
                if (userInput != "yes")
                {
                    continueExecution = false;
                }
            }

            Console.ReadLine();
        }
    }
    
}