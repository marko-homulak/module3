using System;

namespace module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keyHandler = new ButtonHandler();
            var keyDownHandler = new ButtonDownHandler();
            var keyUpHandler = new ButtonUpHandler();
            var mouseHandler = new MouseHandler();
            var mouseDownHandler = new MouseDownHandler();
            var mouseUpHandler = new MouseUpHandler();

            keyDownHandler.SetNext(keyUpHandler).SetNext(keyHandler);
            mouseDownHandler.SetNext(mouseUpHandler).SetNext(mouseHandler);

            HandlerManager.Handle(keyHandler);
            Console.WriteLine();
            HandlerManager.Handle(mouseHandler);
            Console.WriteLine();
            HandlerManager.Handle(mouseDownHandler);

            Console.ReadKey();
        }
    }
}
