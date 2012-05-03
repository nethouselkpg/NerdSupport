using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdSupport.Domain.Model;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.Dsl;

namespace Nerdsupport.Specs.Automation
{
    public static class TestDataCreator
    {
        public static Fixture Fixture
        {
            get { return new Fixture(); }
        }

        public static IPostprocessComposer<T> New<T>() where T : IAggregateRoot
        {
            var type = Activator.CreateInstance<T>();
            IPostprocessComposer<T> returnValue = null;

            TypeSwitch.Do(type,
                          TypeSwitch.Case<Fraga>(() => returnValue = (IPostprocessComposer<T>) NewFraga()),
                          TypeSwitch.Case<ServiceAvtal>(() => returnValue = (IPostprocessComposer<T>) NewAvtal()),
                          TypeSwitch.Case<Nord>(() => returnValue = (IPostprocessComposer<T>)NewNord()));

            return returnValue;

        }

        private static IPostprocessComposer<Fraga> NewFraga()
        {
            return Fixture.Build<Fraga>()
             .With(f => f.Avsandare, new Avsandar { ServiceAvtalId = 1 })
                                       .With(f => f.IsBesvarad, false);

        }

        private static IPostprocessComposer<ServiceAvtal> NewAvtal()
        {
            return Fixture.Build<ServiceAvtal>()
                .With(s => s.Id, 1);
        }

        private static IPostprocessComposer<Nord> NewNord()
        {
            var nord = Fixture.Build<Nord>()
                .With(n => n.Id, 1);

            return nord;
        }

        public static T Create<T>(this IPostprocessComposer<T> composer)
        {
            return ObjectCloner.Clone(composer.CreateAnonymous());
        }
    }
}
