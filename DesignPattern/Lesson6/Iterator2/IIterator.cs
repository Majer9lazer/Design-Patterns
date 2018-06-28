namespace DesignPattern.Lesson6.Iterator2
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}