using System.Collections.Generic;
using System;
using Brasileirao.Api.Models.Common;

namespace Brasileirao.Data.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);

        void Delete(string id);

        void Update(T updatedEntity);

        IEnumerable<T> GetAll();

        T Get(Func<T, bool> predicate);
    }
}