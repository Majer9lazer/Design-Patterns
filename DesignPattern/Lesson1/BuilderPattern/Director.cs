using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public class Director
    {
        private HomeBuilder builder;

        public void StartToBuilt(HomeBuilder builder)
        {
            this.builder = builder;
            builder.BuildHome();
        }
    }
}
