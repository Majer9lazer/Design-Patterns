using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.CompositePattern
{
    class Triangle:IComponent
    {
        public void Draw()
        {
            Console.WriteLine("It is Triangle");
        }
    }
}
