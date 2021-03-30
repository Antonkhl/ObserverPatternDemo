using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Person : Iperson
    {
        public string PersonName { get; private set; }

        public Person(string name)
        {
            PersonName = name;
        }

        public void Update()
        {
            Console.WriteLine(PersonName + ": Someone has Subscribed to your channel!");
        }
    }
}
