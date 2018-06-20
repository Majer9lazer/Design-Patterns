using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.AdapterPattern
{
    public class Application
    {
        protected  void AddApp()
        {
            Console.WriteLine("Apllication add");
        }

        protected void RemoveApp()
        {
            Console.WriteLine("Apllication Remove");
        }

        protected void ModifyApp()
        {
            Console.WriteLine("Apllication Modify");
        }

        protected void CreateApp()
        {
              Console.WriteLine("Apllication Create");
        }
    }
}
