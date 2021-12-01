using System.Collections.Generic;

namespace LoucaLiza.repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T GetById(int Id);

        T Save(T Entity);

        bool Delete(T Entity);
    }
}