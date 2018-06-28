using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson6.Observable
{
    interface IObserver
    {
        void Subscribe(string message,string channelName);
        string UserSubscribe();

    }
}
