using System.Collections.Generic;

namespace CalculadoraCumDAL.Domain
{
    public interface IUpdateRepository<T> where T : class
    {
        void Update(IEnumerable<T> t);
        void Update(T t);
    }
}
