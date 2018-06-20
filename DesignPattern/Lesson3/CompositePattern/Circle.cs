using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Lesson3.CompositePattern;

namespace DesignPattern.Lesson3
{
    class Circle:IComponent
    {
        public void Draw()
        {
            Console.WriteLine("Circle is drawed");
        }
    }
}
