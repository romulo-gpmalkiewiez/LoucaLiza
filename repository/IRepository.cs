using System.Collections.Generic;

namespace LoucaLiza.repository
{
    public interface IRepository<T, F> where F : IFilter<T>
    {
        List<T> GetAll(F filter);

        T Save(T Entity);

        bool Delete(T Entity);
    }
}
