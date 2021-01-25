using System;
using BusinessEntities;

namespace Core.Factories
{
    public interface IIdObjectFactory<out T> : IFactory<T> where T : IdObject
    {
        T Create(Guid id);
    }
}