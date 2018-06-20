using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.BridgePattern
{
    class OrangeWithBlack : IColor
    {
        public void ShowColor()
        {
            Console.WriteLine("Orange with black color");
        }
    }
}
