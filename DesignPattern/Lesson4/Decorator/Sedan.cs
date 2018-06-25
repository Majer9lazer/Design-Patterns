using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson4.Decorator
{
    class Sedan : ICar
    {
        public string ShowInfo()
        {
            return "This is sedan";
        }
    }
}
