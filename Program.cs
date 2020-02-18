using System;

namespace DesignPattern_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Clone1 clone1 = new Clone1("Jango Fett");
            Clone2 clone2 = new Clone2("Stormtrooper1");
            Clone3 clone3 = new Clone3("Stormtrooper1");

            clone1.CloneList.Add(clone2);
            clone1.CloneList.Add(clone3);

            Console.WriteLine(clone1);

            Console.WriteLine("Hello World!");
        }
    }
}
