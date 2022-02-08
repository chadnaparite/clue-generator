using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CluedIn.Connector.DataDefinition.ClueGenerator;
using CluedIn.Connector.DataDefinition.Interfaces;
using CluedIn.Core.Installers;
using CluedIn.Crawling;
using CluedIn.Crawling.Factories;

namespace CluedIn.Connector.DataDefinition.Installers
{
    public class DataDefinitionInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IClueGenerator, ChadClueGenerator>().LifestyleSingleton());
        }
    }
}
