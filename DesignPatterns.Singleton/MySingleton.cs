using System;

namespace DesignPatterns.Singleton
{
    public sealed class MySingleton
    {
        private static readonly Lazy<MySingleton> _instance = new Lazy<MySingleton>(() => new MySingleton());
        public static  MySingleton Instance => _instance.Value;

        private MySingleton(){}

        public void DoSomething()
        {
            //do something
        }
    }
}
