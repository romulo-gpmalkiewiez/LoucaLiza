using LoucaLiza.repository;
using System.Collections.Generic;

namespace LoucaLiza.controller
{
    public interface IController<T>
    {
        List<T> GetAll();

        List<T> GetAll(IFilter<T> filter);

        T Save(T entity);

        bool Delete(T entity);
    }
}
