namespace ViceCity
{
    using System;
    using ViceCity.Core;
    using ViceCity.Core.Contracts;
    using ViceCity.Models.Guns;

    public class StartUp
    {
        IEngine engine;
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
