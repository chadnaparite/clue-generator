using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Chad2.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Chad2.Unit.Test.Chad2Provider
{
    public abstract class Chad2ProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IChad2ClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected Chad2ProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IChad2ClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Chad2.Chad2Provider(applicationContext, NameClientFactory.Object);
        }
    }
}
