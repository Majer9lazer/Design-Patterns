using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson7.Command
{
    class SumCommand : ITransaction
    {
        private readonly Calculator _calculator;
        private readonly int _a;
        private readonly int _b;

        public SumCommand(Calculator calculator, int a, int b)
        {
            _calculator = calculator;
            _a = a;
            _b = b;
        }
        public void Commit()
        {
            Console.WriteLine("Успешно добавили");
        }

        public void Rollback()
        {
            Console.WriteLine("sum command was rollbacked");
        }

        public void Execute()
        {
            try
            {
                _calculator.Sum(_a, _b);
                this.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                this.Rollback();
            }
        }

      
    }
}
