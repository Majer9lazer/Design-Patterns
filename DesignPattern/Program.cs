﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using DesignPattern.Lesson3;
using DesignPattern.Lesson3.AdapterPattern;
using DesignPattern.Lesson3.BridgePattern;
using DesignPattern.Lesson3.CompositePattern;
using DesignPattern.Lesson4.Decorator;
using DesignPattern.Lesson4.Proxy;
using DesignPattern.Lesson6.Iterator;
using DesignPattern.Lesson6.Iterator2;
using DesignPattern.Lesson6.Observable;
using DesignPattern.Lesson7.Command;

namespace DesignPattern
{
    class Program
    {
        private static void Main(string[] args)
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
            #region BridggePattern
            //Car buggatyCar = new Bugatti(new OrangeWithBlack(), new Sport());
            //buggatyCar.ApplyColorAndType();
            #endregion
            #region AdapterPattern

            //Adapter adapter = new Adapter();
            //Task task = new Task(() =>
            //  {
            //      adapter.Create();
            //  });
            //Task task1 = new Task(() =>
            //{
            //    adapter.Insert();
            //});
            //Task task2 = new Task(() =>
            //{
            //    adapter.Update();
            //});
            //Task task3 = new Task(() =>
            //{
            //    adapter.Delete();
            //});


            //task2.Start();
            //task3.Start();
            //task.Start();
            //task1.Start();

            #endregion
            #endregion

            #region Lesson4
            #region Proxy
            //IServer server = new ProxyServer("www.google.com");
            //server.ProcessRequest();

            #endregion
            #region Decorator
            //ICar car = new CarDecorator(new SportSedan(new Sedan()));
            //Console.WriteLine(car.ShowInfo());
            #endregion
            #region Facade
            #endregion
            #endregion

            #region Lesson5
            #endregion

            #region Lesson6
            #region Iterator
            #region Task1
            //string[] skiStrings = new[] {"Csharp", ".NET", "MySql"};
            //DeveloperIter developerIter= new DeveloperIter("Egor",skiStrings);

            //IIterator terator = developerIter.ITerator();
            //while (terator.HasNext())
            //{
            //    Console.WriteLine(terator.Next());
            //}
            #endregion
            #region Task2
            //ArrayList<String> arrayList = new ArrayList<string>(10);
            //for (int i = 0; i < 100; i++)
            //{
            //    arrayList.Add("Element_" + i);
            //    arrayList.RemoveLast();
            //}

            //IIterator<string> iterator = arrayList.GetIterator();
            //while (iterator.HasNext())
            //{
            //    Console.WriteLine(iterator.Next());
            //}
            #endregion
            #endregion

            #region Observable
            //YouTubeChannel channel = new YouTubeChannel("Some");
            //YouTubeChannel channel2 = new YouTubeChannel("Another");
            //Subscriber subscriber = new Subscriber("Egor", channel);
            //Subscriber subscriber2 = new Subscriber("Nastya", channel2);
            //channel.AddObserver(subscriber);
            //channel2.AddObserver(subscriber2);
            //channel.AddVideo("Привет из паттернов программирования");
            #endregion
            #endregion

            #region Lesson7

            #region Command

            Calculator calculator = new Calculator();
            Terminal terminal = new Terminal(new SumCommand(calculator, 5, 4));
            terminal.Sum();
            terminal = new Terminal(new SumCommand(calculator, 10, 5));
            terminal.Sum();
            #endregion

            #endregion
            Console.ReadLine();
        }

    }
}
