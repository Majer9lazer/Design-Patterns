using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.BridgePattern
{
    class Bugatti:Car
    {
        public Bugatti(IColor color, IType type) : base(color, type)
        {
        }

        public override void ApplyColorAndType()
        {
            Console.WriteLine("IT IS BUGGATTI");
            Color.ShowColor();
            Type.ShowType();
        }
    }
}
