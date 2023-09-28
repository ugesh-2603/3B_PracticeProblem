using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B_PracticeProblem
{
    public class Access_Modifiers
    {
        public int PublicField = 10; // Accessible from anywhere
        private int PrivateField = 20; // Accessible only within this class
        protected int ProtectedField = 30; // Accessible within this class and derived classes
        internal int InternalField = 40; // Accessible within the same assembly

        // Constructors are usually public by default
        public Access_Modifiers()
        {
            Console.WriteLine("Base class constructor called.");
        }

        // Public method accessible from anywhere
        public void PublicMethod()
        {
            Console.WriteLine("Public method called.");
        }

        // Private method accessible only within this class
        private void PrivateMethod()
        {
            Console.WriteLine("Private method called.");
        }

        // Protected method accessible within this class and derived classes
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method called.");
        }

        // Internal method accessible within the same assembly
        internal void InternalMethod()
        {
            Console.WriteLine("Internal method called.");
        }
    }

    // Derived class
    public class MyDerivedClass : Access_Modifiers
    {
        public void AccessBaseClassMembers()
        {
            Console.WriteLine($"PublicField from derived class: {PublicField}");
            // PrivateField is not accessible in the derived class
            Console.WriteLine($"ProtectedField from derived class: {ProtectedField}");
            Console.WriteLine($"InternalField from derived class: {InternalField}");

            // PublicMethod is accessible from anywhere
            PublicMethod();
            // PrivateMethod is not accessible in the derived class
            ProtectedMethod();
            InternalMethod();
        }
    }
}

