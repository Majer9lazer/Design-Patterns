using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson2.SingletonPattern
{
    public class Logger
    {
        private static Logger log;
        private Logger() { }
        public static DirectoryInfo DirectoryInfo = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent?.Parent;

        public static Logger GetLogger()
        {
            if (log == null)
                log = new Logger();

            lock (log)
                return log;


        }

        public void ShowInfo()
        {
            Console.WriteLine(DirectoryInfo.FullName);
        }
    }
}
