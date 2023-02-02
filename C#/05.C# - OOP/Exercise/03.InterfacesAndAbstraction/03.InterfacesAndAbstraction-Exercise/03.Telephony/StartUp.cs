using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ICallable caller = new Smartphone();
            IBrowsable browser = new Smartphone();

            Engine engine = new Engine(caller, browser);
            engine.Run();

        }
    }
}
