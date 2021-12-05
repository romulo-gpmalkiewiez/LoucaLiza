using System.Collections.Generic;

namespace LoucaLiza.repository
{
    public interface IRepository<T, F> where F : IFilter<T>
    {
        List<T> FindAll();

        List<T> FindAll(F filter);

        T Save(T Entity);

        bool Delete(T Entity);
    }
}
