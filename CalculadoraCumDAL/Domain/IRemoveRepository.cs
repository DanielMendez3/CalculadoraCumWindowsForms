using System.Collections.Generic;

namespace CalculadoraCumDAL.Domain
{
    public interface IRemoveRepository<T> where T : class
    {
        void Remove(IEnumerable<T> t);
        void Remove(T t);
    }
}
