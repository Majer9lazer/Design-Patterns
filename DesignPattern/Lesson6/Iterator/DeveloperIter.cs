using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson6.Iterator
{
    internal class DeveloperIter : IIterable
    {
        private string _name;
        private string[] _skills;

        public DeveloperIter(string name, string[] skills)
        {
            _name = name;
            _skills = skills;
        }

        public IIterator ITerator()
        {
            return new SkillIterator(this);
        }

        public class SkillIterator : IIterator
        {
            private int _index;
            private DeveloperIter _developer;

            public SkillIterator(DeveloperIter developer)
            {
                _developer = developer;
            }

            public bool HasNext()
            {
                return _index < _developer._skills.Length;
            }

            public object Next()
            {
                return _developer._skills[_index++];
            }
        }
    }
}
