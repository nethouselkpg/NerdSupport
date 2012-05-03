using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Ploeh.AutoFixture;
using NerdSupport.Domain.Model;

namespace Nerdsupport.Specs.Automation
{
    public static class SpecflowHelper
    {
        public static List<T> GenerateTestDataFrom<T>(this Table table) where T : class, IAggregateRoot
        {
            var testData = table.CreateSet<T>().ToList();

            foreach(var item in testData)
            {
                MergeWithGeneratedData(item);
            }

            return testData;
        }

        private static void MergeWithGeneratedData<T>(T originalData) where T : class, IAggregateRoot
        {
            var secondary = TestDataCreator.New<T>().Create();

            foreach (var pi in typeof(T).GetProperties())
            {
                var priValue = pi.GetGetMethod().Invoke(originalData, null);
                var secValue = pi.GetGetMethod().Invoke(secondary, null);
                if (priValue == null || (pi.PropertyType.IsValueType && priValue == Activator.CreateInstance(pi.PropertyType)))
                {
                    pi.GetSetMethod().Invoke(originalData, new object[] { secValue });
                }
            }
        }
    }
}
