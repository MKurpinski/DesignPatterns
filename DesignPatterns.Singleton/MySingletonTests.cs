using NUnit.Framework;

namespace DesignPatterns.Singleton
{
    [TestFixture]
    public class MySingletonTests
    {
        [Test]
        public void TwoInstancesOfSingleton_ShouldBeTheSame()
        {
            var singleton1 = MySingleton.Instance;
            var singleton2 = MySingleton.Instance;

            Assert.AreSame(singleton1, singleton2);
        }
    }
}
