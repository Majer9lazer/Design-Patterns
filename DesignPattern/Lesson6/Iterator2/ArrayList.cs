using System;

namespace DesignPattern.Lesson6.Iterator2
{
    public class ArrayList<T> : IIterable<T>
    {
        private T[] _array;
        private int index;

        public ArrayList(int length)
        {
            _array = new T[length];
            index = 0;
        }

        public ArrayList(T[] array)
        {
            _array = array;
            index = 0;
        }

        public T this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }

        public void Add(T element)
        {
            if (index >= _array.Length)
                Array.Resize(ref _array, _array.Length + 5);
            _array[index] = element;

            index++;
        }

        public T GetFirst()
        {
            return _array[0];
        }

        public T GetLast()
        {
            return _array[_array.Length - 1];
        }

        public int GetLength()
        {
            return _array.Length;
        }

        public IIterator<T> GetIterator()
        {
            return new ArrayListIterator(this);
        }

        public void RemoveByIndex(int index)
        {
            _array[index] = default(T);
        }

        public void RemoveLast()
        {
            if (index != _array.Length - 1)
            {
                index = _array.Length - 1;
            }
            _array[index] = default(T);
            index--;
        }

        private class ArrayListIterator : IIterator<T>
        {
            private IIterable<T> _arrayList;
            private int _index;

            public ArrayListIterator(IIterable<T> arrayList)
            {
                _arrayList = arrayList;
            }

            public bool HasNext()
            {
                return _index < _arrayList.GetLength();
            }

            public T Next()
            {
                return _arrayList[_index++];
            }
        }

    }
}