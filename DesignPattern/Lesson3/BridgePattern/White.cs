using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.BridgePattern
{
    class White:IColor
    {
        public void ShowColor()
        {
            Console.WriteLine("white color");
        }
    }
}
