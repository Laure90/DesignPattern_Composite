using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Composite
{
    public abstract class Person
    {
        public string Name { get; set;}
        public List<Person> CloneList { get; set; } = new List<Person>();

        public Person(string name)
        {
            Name = name;
        }

        public override String ToString()
        {
            string resultClone = Name + "\n\t";
            foreach(Person clone in CloneList)
            {
                resultClone = resultClone + clone.ToString();
            }
            return resultClone;
        }

    }
}
