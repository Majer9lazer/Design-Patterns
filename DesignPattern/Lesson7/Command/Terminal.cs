using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson7.Command
{
    class Terminal
    {
        private ICommand _sumCommand;
        
        public Terminal(ICommand sumCommand)
        {
            _sumCommand = sumCommand;
        }

        public void Sum()
        {
            
            _sumCommand.Execute();
        }


    }
}
