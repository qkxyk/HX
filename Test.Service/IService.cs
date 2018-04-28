using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Service
{
    public interface IService<TEntity>
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> Get();

        void Delete(TEntity entity);
    }
}
