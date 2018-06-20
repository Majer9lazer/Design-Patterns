using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.Lesson3;
using DesignPattern.Lesson3.CompositePattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lesson1
            #region FabricPattern
            /*
             *FabricRealization
            
            Fabric androidFabric = new AndroidFabric();
            Developer androidDeveloper = androidFabric.GetDeveloper();

            Fabric iosFabric = new IosFabric();
            Developer iosDeveloper = iosFabric.GetDeveloper();

            androidDeveloper.CreateProject();

            iosDeveloper.CreateProject();
             */
            #endregion
            #region BuilderPattern
            //Director director = new Director();
            //HomeBuilder builder = new StoneHomeBuilder();
            //director.StartToBuilt(builder);

            //builder.ShowInfo();


            #endregion
            #endregion

            #region Lesson2

            #region SingletonPattern
            //Random random = new Random();
            //Logger log = Logger.GetLogger();
            //Thread[] threads = new Thread[]
            //{
            //    new Thread(delegate()
            //    {
            //        log.ShowInfo();
            //    }),new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ");
            //        log.ShowInfo();
            //    }),
            //    new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }),
            //    new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }), new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }), new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }), new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }), new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }), new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }), new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }), new Thread(delegate()
            //    {
            //        Logger.DirectoryInfo = new DirectoryInfo(@"C:\Users\СидоренкоЕ"+random.Next());
            //        log.ShowInfo();
            //    }),

            //};
            //threads.ToList().ForEach(f => f.Start());

            #endregion

            #region PrototypePattern

            //Qwerty qwerty = new Qwerty("dsad", 45.4);
            //Qwerty wfwer = (Qwerty)qwerty.clone(qwerty);

            //qwerty.ShowInfo();
            //wfwer.ShowInfo();

            #endregion

            #region FactoryMethod
            #endregion
            #endregion

            #region Lesson3
            #region CompositePattern
            // Composite com = new Composite("Root");
            // Task t = new Task(() =>
            //  {
            //      IComponent triangle = new Triangle();
            //      IComponent circle = new Circle();
            //      com.Add(triangle);
            //      com.Add(circle);
            //  });
            //Task t1 = new Task(() =>
            //  {
            //      com.Show();
            //      Console.ForegroundColor = ConsoleColor.Green;
            //      Console.WriteLine("-----Press any key to Exit-----");
            //      Console.ForegroundColor = ConsoleColor.White;
            //  });
            // t.Start();
            // t1.Start();
            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.WriteLine("-----Waiting for the thread...");
            // Console.ForegroundColor = ConsoleColor.White;
            // Console.ReadLine();
            #endregion

            #region AdapterPattern

            

            #endregion
            #endregion
        }
    }
}
