using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.BridgePattern
{
    class Sport:IType
    {
        public void ShowType()
        {
            Console.WriteLine("It is sport");
        }
    }
}
