using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.BridgePattern
{
    public abstract class Car
    {
        protected IColor Color;
        protected IType Type;
        protected Car(IColor color, IType type)
        {
            Color = color;
            Type = type;
        }

        public abstract void ApplyColorAndType();
    }
}
