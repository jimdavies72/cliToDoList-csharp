namespace todoCSharp.src.interfaces
{
  public interface IIterator<T>
  {
    void Next();
    bool HasNext();
    T Current();
  } 
}