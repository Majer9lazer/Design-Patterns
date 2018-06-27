using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson6.Iterator
{
    interface IIterator
    {
        bool HasNext();
        object Next();
    }
}
