using System;
using System.Collections.Generic;
namespace module
{
    public class HandlerManager
    {
        private static List<string> actions = new List<string> { "Key", "KeyDown", "KeyUp", "Mouse", "MouseDown", "MouseUp", "Touch" };

        public static void Handle(Handler _handler)
        {
            foreach (var action in actions)
            {
                var result = _handler.Handle(action);

                if (result != null) Console.Write($"   {result}");
            }
        }
    }
}
