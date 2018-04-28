using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test.Repository
{
    public class DeviceRepository : IRepository<DeviceModel, string>
    {
        public void Add(DeviceModel instance)
        {
            using (var db = new TestHXContext())
            {
                db.Device.Add(instance);
                db.SaveChanges();
            }
        }

        public int Count(Expression<Func<DeviceModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(DeviceModel instance)
        {
            using (var db = new TestHXContext())
            {
                db.Entry<DeviceModel>(instance).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public IEnumerable<DeviceModel> Get()
        {
            using (var db = new TestHXContext())
            {
                List<DeviceModel> list = db.Device.ToList();
                return list;
            }
        }

        public IEnumerable<DeviceModel> Get(Expression<Func<DeviceModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DeviceModel> Get<TOrderKey>(Expression<Func<DeviceModel, bool>> filter, int pageIndex, int pageSize, Expression<Func<DeviceModel, TOrderKey>> sortExpression, bool isAsc = true)
        {
            throw new NotImplementedException();
        }

        public void Update(DeviceModel instance)
        {
            throw new NotImplementedException();
        }
    }
}
