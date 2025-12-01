using MyWebApplication.Abstraction;

namespace MyWebApplication.Services;

public class RequestCounterService : IRequestCounter
{
    private int _count = 0;

    public void Increment()
    {
        _count++;
    }

    public int GetCount()
    {
        return _count;
    }
}
