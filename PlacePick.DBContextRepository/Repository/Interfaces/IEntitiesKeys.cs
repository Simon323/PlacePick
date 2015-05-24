using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacePick.DBContextRepository.Repository.Interfaces
{
    public interface IEntitiesKeys<T>
    {
        List<string> GetKeyNames();

        List<object> GetKeys(T item);

        IQueryable<T> GetByKeys(List<object> keys);
    }
}
