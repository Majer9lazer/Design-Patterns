using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.AdapterPattern
{
    class Adapter : Application, IEntity
    {
     
        public void Create()
        {
            this.CreateApp();
        }

        public void Update()
        {
            ModifyApp();
        }

        public void Delete()
        {
            RemoveApp();
        }

        public void Insert()
        {
           AddApp();
            
        }


    }
}
