using System;
using NerdSupport.Domain.Model;
namespace NerdSupport.Domain.Factories
{
    public interface IFactory<T> where T : IAggregateRoot
    {
        T Skapa();

        T Hamta(long id);
    }
}
