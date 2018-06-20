using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.BridgePattern
{
    class General:IType
    {
        public void ShowType()
        {
            Console.WriteLine("It is general");
        }
    }
}
