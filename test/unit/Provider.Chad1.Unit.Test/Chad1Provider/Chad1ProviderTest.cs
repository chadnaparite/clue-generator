using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Chad1.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Chad1.Unit.Test.Chad1Provider
{
    public abstract class Chad1ProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IChad1ClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected Chad1ProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IChad1ClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Chad1.Chad1Provider(applicationContext, NameClientFactory.Object);
        }
    }
}
