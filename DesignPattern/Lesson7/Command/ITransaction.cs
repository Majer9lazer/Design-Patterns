using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson7.Command
{
    interface ITransaction : ICommand
    {
        void Commit();
        void Rollback();
    }
}
