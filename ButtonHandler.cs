namespace module
{
    public class ButtonHandler : Handler
    {
        public override object Handle(object _request)
        {
            if ((_request as string) == "Key")
            {
                return $"ButtonHandler: processing get {_request.ToString()}.\n";
            }
            else
            {
                return base.Handle(_request);
            }
        }
    }

    public class ButtonDownHandler : Handler
    {
        public override object Handle(object _request)
        {
            if ((_request as string) == "KeyDown")
            {
                return $"ButtonDownHandler: processing get {_request.ToString()}.\n";
            }
            else
            {
                return base.Handle(_request);
            }
        }
    }

    public class ButtonUpHandler : Handler
    {
        public override object Handle(object _request)
        {
            if ((_request as string) == "KeyUp")
            {
                return $"ButtonUpHandler: processing get {_request.ToString()}.\n";
            }
            else
            {
                return base.Handle(_request);
            }
        }
    }
}
