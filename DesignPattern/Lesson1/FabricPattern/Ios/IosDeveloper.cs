using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Ios
{
    class IosDeveloper : Developer
    {
        public IosDeveloper()
        {
            KindOfDeveloper = TypeOfDeveloper.Ios;
        }
        public TypeOfDeveloper KindOfDeveloper { get; set; }
        public void CreateProject()
        {
            Console.WriteLine(KindOfDeveloper.ToString() + " Developer" + $" Creates {KindOfDeveloper} Project");
        }
    }
}
