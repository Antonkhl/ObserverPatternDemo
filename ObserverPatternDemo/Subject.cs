using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subject : ISubject
    {
        private List<Person> Persons = new List<Person>();
        private int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void Subscribe(Person Person)
        {
            Persons.Add(Person);
        }

        public void Unsubscribe(Person Person)
        {
            Persons.Remove(Person);
        }

        public void Notify()
        {
            foreach (var Person in Persons)
            {
                Person.Update();
            }
        }
    }
}
