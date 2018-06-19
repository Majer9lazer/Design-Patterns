using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DesignPattern.Android;
using DesignPattern.BuilderPattern;
using DesignPattern.Ios;
using DesignPattern.Lesson2.FactoryMethod;
using DesignPattern.Lesson2.ProtoTypePattern;
using DesignPattern.Lesson2.SingletonPattern;

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

        }
    }
}
