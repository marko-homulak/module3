namespace module
{
    public abstract class Handler : IHandler
    {
        private IHandler nextHandler;

        public IHandler SetNext(IHandler _handler)
        {
            nextHandler = _handler;

            return _handler;
        }

        public virtual object Handle(object _request)
        {
            if (nextHandler != null)
            {
                return nextHandler.Handle(_request);
            }
            else
            {
                return null;
            }
        }
    }
}
