using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobMatch.Database
{
    public interface IController<T>
    {
            void Insert(T obj);
            T Select(int id);
            void Update(T obj);
            void Delete(int id);
    }
}
