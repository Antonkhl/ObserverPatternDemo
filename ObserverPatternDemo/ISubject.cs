using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    interface ISubject
    {
        void Subscribe(Person person);
        void Unsubscribe(Person person);
        void Notify();
    }
}
