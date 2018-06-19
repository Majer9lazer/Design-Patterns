using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public class Home
    {
        public Roof Roof { get; set; } = new Roof();
        public Wall[] Walls { get; set; } = new Wall[4];
        public Groundwork Groundwork { get; set; } = new Groundwork();
        public string Name { get; set; }

        public void ShowInfo()
        {
            foreach (PropertyInfo info in GetType().GetProperties())
            {
                Console.WriteLine(info.Name + " value - " + info.GetValue(this));
            }
        }
    }
}
