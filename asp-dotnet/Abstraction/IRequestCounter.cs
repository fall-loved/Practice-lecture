namespace MyWebApplication.Abstraction;

public interface IRequestCounter
{
    void Increment();
    int GetCount();
}
