using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Android
{
    class AndroidDeveloper : Developer
    {
        public TypeOfDeveloper KindOfDeveloper { get; set; }

        public AndroidDeveloper()
        {
            KindOfDeveloper = TypeOfDeveloper.Android;
        }
        public void CreateProject()
        {
            Console.WriteLine(KindOfDeveloper.ToString() + " Developer" + $" Creates {KindOfDeveloper} Project");
        }
    }
}
