using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.AdapterPattern
{
    public interface IEntity
    {
        void Create();
        void Update();
        void Delete();
        void Insert();
    }
}
