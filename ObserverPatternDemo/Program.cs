using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Person person1 = new Person("Person 1");
            subject.Subscribe(person1);

            Person person2 = new Person("Person 2");
            subject.Subscribe(person2);

            subject.Inventory++;

            Person person3 = new Person("Person 3");
            subject.Subscribe(person3);

            subject.Inventory++;

            Console.ReadLine();
        }
    }
}
