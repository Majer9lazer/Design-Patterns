using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Android
{
    public class AndroidFabric : Fabric
    {
        public Developer GetDeveloper()
        {
            return new AndroidDeveloper();
        }
    }
}
