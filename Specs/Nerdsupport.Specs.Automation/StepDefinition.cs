using System.Collections.Generic;
using DeleporterCore.Client;
using Moq;
using NerdSupport.Domain.Model;
using NerdSupport.Domain.Repositories;
using NerdSupport.Infrastructure.Configuration;
using Ploeh.AutoFixture.Dsl;

namespace Nerdsupport.Specs.Automation
{
    public class StepDefinition : RepositoryMocker
    {
        protected NordWorkflow _arbetsflode = new NordWorkflow();

        public void InjectPreconditions<T>(T item) where T : class, IAggregateRoot
        {
            Deleporter.Run(() =>
                               {
                                   Mock<IRepository<T>> repoMock = SetupRepository(new List<T> {item});
                                   IoC.InjectBinding(typeof (IRepository<T>), repoMock.Object);
                               });
        }

        public void InjectPreconditions<T>(List<T> items) where T : class, IAggregateRoot
        {
            Deleporter.Run(() =>
                               {
                                   Mock<IRepository<T>> repoMock = SetupRepository(items);
                                   IoC.InjectBinding(typeof (IRepository<T>), repoMock.Object);
                               });
        }

        public void SetupDefaults()
        {
            ServiceAvtal avtal = TestDataCreator.New<ServiceAvtal>().Create();
            InjectPreconditions(avtal);

            Fraga fragor = TestDataCreator.New<Fraga>().Create();
            InjectPreconditions(fragor);

            Nord nord = TestDataCreator.New<Nord>().Create();
            InjectPreconditions(nord);
        }

        public IPostprocessComposer<T> New<T>() where T : IAggregateRoot
        {
            return TestDataCreator.New<T>();
        }
    }
}