using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B_PracticeProblem
{
    internal class Constructor
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Default Constructor
        public Constructor()
        {
            Name = "Karthi";
            Age = 30;
        }

        // Parameterized Constructor
        public Constructor(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy Constructor
        public Constructor(Constructor otherPerson)
        {
            Name = otherPerson.Name;
            Age = otherPerson.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
