using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson2.ProtoTypePattern
{
    public class Qwerty : Clonable
    {
        public Qwerty(string Type, double Weight)
        {
            this.Type = Type;
            this.Weight = Weight;
        }
        public Qwerty Clone(Object obj)
        {
            return (Qwerty)obj;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Type - {0} , Weight - {1}", Type, Weight);
        }

        public override Clonable clone(object obj)
        {
            return (Qwerty)obj;
        }
    }
}
