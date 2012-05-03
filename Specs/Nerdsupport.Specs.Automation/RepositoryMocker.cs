using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NerdSupport.Domain.Repositories;
using NerdSupport.Domain.Model;
using System.Linq.Expressions;

namespace Nerdsupport.Specs.Automation
{
    public class RepositoryMocker
    {
        public Mock<IRepository<T>> SetupRepository<T>(List<T> items) where T : class, IAggregateRoot
        {
            var repoMock = new Mock<IRepository<T>>();

            repoMock.Setup(m => m.GetAll()).Returns(items);

            repoMock.Setup(m => m.GetById(It.IsAny<long>())).Returns((long id) => 
            {
                return items.Single(item => item.Id == id);
            });

            repoMock.Setup(m => m.Add(It.IsAny<T>())).Callback((T item) => {
                items.Add(item);
            });


            repoMock.Setup(m => m.Get(It.IsAny<Expression<Func<T, bool>>>())).Returns((Func<T, bool> expr) =>
            {
                return items.SingleOrDefault(expr);
            });
            
            repoMock.SetupAllProperties();

            return repoMock;
        }
    }
}
