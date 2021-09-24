using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Polymorphism
    {
        // Method Overloading : Diff type of parameter,no of parameter, squence of parameter.

        //public void Display(string name,int fees,string className)
        //{
        //    Console.WriteLine($"My name is {name} and i am study in {className} i give my fees {fees}");
        //}
        //public void Display(string name, int fees)
        //{
        //    Console.WriteLine($"My name is {name} and  i give my fees {fees}");
        //}
        //public void Display(string name,string className)
        //{
        //    Console.WriteLine($"My name is {name} and i am study in {className} ");
        //}
        //public void Display(int fees, string className, string name)
        //{
        //    Console.WriteLine($"My name is {name} and i am study in {className} i give my fees {fees}");
        //}

        // Method Overriding 

        public void Display(string name, int fees, string className)
        {
            Console.WriteLine($"Polymorphism My name is {name} and i am study in {className} i give my fees {fees}");
        }

    }
}
