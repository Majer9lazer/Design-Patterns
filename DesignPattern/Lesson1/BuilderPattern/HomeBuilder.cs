using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
   public abstract class HomeBuilder
    {
        protected Home home=new Home();

        public abstract void BuildHome();
        public abstract void ShowInfo();

    }
}
