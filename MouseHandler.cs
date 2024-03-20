namespace module
{
    public class MouseHandler : Handler
    {
        public override object Handle(object _request)
        {
            if ((_request as string) == "Mouse")
            {
                return $"MouseHandler: processing click {_request.ToString()}.\n";
            }
            else
            {
                return base.Handle(_request);
            }
        }
    }

    public class MouseDownHandler : Handler
    {
        public override object Handle(object _request)
        {
            if ((_request as string) == "MouseDown")
            {
                return $"MouseDownHandler: processing {_request.ToString()}.\n";
            }
            else
            {
                return base.Handle(_request);
            }
        }
    }

    public class MouseUpHandler : Handler
    {
        public override object Handle(object _request)
        {
            if ((_request as string) == "MouseUp")
            {
                return $"MouseUpHandler: processing {_request.ToString()}.\n";
            }
            else
            {
                return base.Handle(_request);
            }
        }
    }
}
