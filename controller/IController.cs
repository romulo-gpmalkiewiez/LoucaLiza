using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    public interface IController<T>
    {
        T Save(T entity);

        bool Delete(T entity);

        List<T> GetByFilter(IFilter<T> filter);
    }
}
