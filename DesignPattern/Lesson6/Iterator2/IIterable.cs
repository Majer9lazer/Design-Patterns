namespace DesignPattern.Lesson6.Iterator2
{
    interface IIterable<T>
    {
        void RemoveLast();
        void RemoveByIndex(int index);
        void Add(T element);
        T GetFirst();
        T GetLast();
        int GetLength();
        IIterator<T> GetIterator();
        T this[int index] { get; set; }
    }
}