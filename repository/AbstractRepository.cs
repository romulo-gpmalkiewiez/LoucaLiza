using System;
using System.Collections.Generic;
using System.Linq;

namespace LoucaLiza.repository
{
    public abstract class AbstractRepository<T, F> : IRepository<T, F> where F : IFilter<T>
    {
        public abstract List<T> FindAll();

        public abstract List<T> FindAll(F filter);

        public abstract T Save(T Entity);

        public abstract bool Delete(T Entity);

        protected IEnumerable<T> AddRestriction<FilterObject>(IEnumerable<T> list, FilterObject obj, Func<T, bool> predicate)
        {
            if (obj == null)
            {
                return list;
            }

            if (obj is string && string.IsNullOrEmpty(obj.ToString()))
            {
                return list;
            }

            return list.Where(predicate);
        }
    }
}
