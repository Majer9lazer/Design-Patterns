using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson6.Iterator
{
    class EArrayList:IIterable
    {
        private int[] _array;
        private int _size;
        private int index;
        public EArrayList(int size)
        {
            _size = size;
            _array = new int[_size];
            index = 0;
        }

        public void Add(int obj)
        {
            if(index>=_array.Length)
                Array.Resize(ref _array,_array.Length+5);
            _array[index] = obj;
            index++;
        }

        public bool IsEmpty() => _size > 0;
        public int GetSize() => _size;
        public void Remove(int obj)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_array[i] == obj)
                {
                    _array[i] = 0;
                    _size++;
                    break;
                }
            }
        }

        public void Show()
        {
            foreach (int i in _array)
            {
                Console.WriteLine(i + " ");
            }
        }

        public IIterator ITerator()
        {
            return new ArrayIterator(this);
        }
        public class ArrayIterator:IIterator
        {
            private int _index;
            private EArrayList _eArrayList;

            public ArrayIterator(EArrayList eArrayList)
            {
                _eArrayList = eArrayList;
            }

            public bool HasNext()
            {
                return _index < _eArrayList._size;
            }

            public object Next()
            {
                return _eArrayList._array[_index++];
            }
        }
    }
}
