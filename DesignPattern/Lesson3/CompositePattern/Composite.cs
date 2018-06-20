using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson3.CompositePattern
{
    class Composite:IComponent

    {
        private readonly List<IComponent> _components = new List<IComponent>();
        private readonly string _name;

        public Composite(string name)
        {
            this._name = name;
        }
        public void Add(IComponent component)
        {
            lock (component)
            {
                _components.Add(component);
            }
           
        }
        public void Remove(IComponent component)
        {
            lock (component)
            {
                _components.Remove(component);
            }
            
        }

        public void Show()
        {
            lock (this)
            {
                Console.WriteLine("Name = {0}",_name);
                for (int i = 0; i < _components.Count; i++)
                {
                    _components[i].Draw();
                }
            }
        }
        public void Draw()
        {
            
        }
    }
}
