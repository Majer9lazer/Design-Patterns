using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DesignPattern.Lesson2.FactoryMethod
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Deconstruct(out string name, out int age)
        {
            name = this.Name;
            age = this.Age;
        }

        public void ManyParametersFunc(params int[] parameters)
        {

            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < parameters.Length; i++)
                Console.Write(parameters[i] + " ");
            Console.Clear();

            t.Stop();

            string s = String.Format("For - Elapsed - {0} seconds , {1} milliseconds", t.ElapsedMilliseconds / 1000, t.ElapsedMilliseconds);

            Console.Clear();
            t.Restart();
            foreach (int i in parameters)
            {
                Console.Write(i + " ");
            }
            Console.Clear();
            t.Stop();
            Console.WriteLine(s);
            Console.WriteLine("Foreach Elapsed - {0} seconds , {1} milliseconds", t.ElapsedMilliseconds / 1000, t.ElapsedMilliseconds);

        }



        public void ManyParametersFunc(params char[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Console.WriteLine(parameters[i]);
            }
        }

    }
}
