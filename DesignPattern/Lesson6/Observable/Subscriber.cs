using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson6.Observable
{
    class Subscriber : IObserver
    {
        private IObservable _observable;
        private string _name;

        public Subscriber(string name, IObservable observable)
        {
            _name = name;
            _observable = observable;
        }
        public void Subscribe(string message, string chanelName)
        {
            Console.WriteLine(chanelName + " has uploaded new video\n" +
                              "{0}", message);
            
        }

        public string UserSubscribe()
        {
            return string.Format("User : {0} subscibed at {1}",_name,_observable.GetName());
        }
    }
}
