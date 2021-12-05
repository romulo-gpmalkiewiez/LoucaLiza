using System;
using System.Collections.Generic;
using System.Linq;

namespace LoucaLiza.repository
{
    public abstract class AbstractRepository<T, F> : IRepository<T, F> where F : IFilter<T>
    {
        public abstract bool Delete(T Entity);

        public abstract List<T> GetAll(F filter);

        public abstract T Save(T Entity);

        protected IEnumerable<T> AddRestriction<FilteringObject>(IEnumerable<T> list, FilteringObject obj, Func<T, bool> predicate)
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
