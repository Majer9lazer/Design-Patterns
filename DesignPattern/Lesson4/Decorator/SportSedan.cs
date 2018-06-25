using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson4.Decorator
{
    internal class SportSedan : CarDecorator
    {
        public SportSedan(ICar car) : base(car)
        {

        }

        internal string ShowSpeed()
        {
            return " , his speed is high";
        }

        public override string ShowInfo()
        {
            return base.ShowInfo() + ShowSpeed();
        }
    }
}
