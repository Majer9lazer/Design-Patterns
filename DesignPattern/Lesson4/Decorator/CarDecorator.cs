using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson4.Decorator
{
    class CarDecorator : ICar
    {
        private readonly ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }
        public virtual string ShowInfo()
        {
            return _car.ShowInfo();
        }
    }
}
