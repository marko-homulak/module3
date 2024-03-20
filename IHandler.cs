namespace module
{
    public interface IHandler
    {
        IHandler SetNext(IHandler _handler);

        object Handle(object _request);
    }
}
