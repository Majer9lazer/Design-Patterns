using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson2.ProtoTypePattern
{
    public abstract class Clonable
    {
        public string Type { get; set; }
        public double Weight { get; set; }
        public abstract Clonable clone(object obj);
    }
}
