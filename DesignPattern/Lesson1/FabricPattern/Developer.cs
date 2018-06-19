using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public enum TypeOfDeveloper
    {
        Android, Ios
    }

    public interface Developer
    {
        TypeOfDeveloper KindOfDeveloper { get; set; }
        void CreateProject();
    }
}
