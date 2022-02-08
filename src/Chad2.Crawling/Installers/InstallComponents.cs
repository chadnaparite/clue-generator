using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CluedIn.Connector.DataDefinition.Installers;
using CluedIn.Core;

namespace CluedIn.Crawling.Chad2.Installers
{
    public class InstallComponents : IWindsorInstaller
    {
        public void Install([NotNull] IWindsorContainer container, [NotNull] IConfigurationStore store)
        {
            if (container == null) throw new ArgumentNullException(nameof(container));
            if (store == null) throw new ArgumentNullException(nameof(store));

            // TODO Add further dependencies to the container here ...
            container.Install(new DataDefinitionInstaller());
        }
    }
}
