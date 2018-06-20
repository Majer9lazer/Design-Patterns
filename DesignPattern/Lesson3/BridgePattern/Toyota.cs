using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.BridgePattern
{
    class Toyota:Car
    {
        public Toyota(IColor color, IType type) : base(color, type)
        {
        }

        public override void ApplyColorAndType()
        {
            Console.WriteLine("Toyota with");
            Type.ShowType();
            Color.ShowColor();
        }
    }
}
