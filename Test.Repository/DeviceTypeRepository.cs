using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test.Model;

namespace Test.Repository
{
    public class DeviceTypeRepository : IRepository<DeviceTypeModel, int>
    {
        public void Add(DeviceTypeModel instance)
        {
            using (var db = new TestHXContext())
            {
                db.DeviceType.Add(instance);
                db.SaveChanges();
            }
        }

        public int Count(Expression<Func<DeviceTypeModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Delete(DeviceTypeModel instance)
        {
            using (var db = new TestHXContext())
            {
                DeviceTypeModel dtm = db.DeviceType.Find(instance.Id);
                db.Entry<DeviceTypeModel>(dtm).State = System.Data.Entity.EntityState.Deleted;
                //获取关联的设备并更新外键为Null
                var d = db.Device.Where(a => a.TypeId == instance.Id);
                foreach (var item in d)
                {
                    item.TypeId = null;
                }
                db.SaveChanges();
            }
        }

        public IEnumerable<DeviceTypeModel> Get()
        {
            using (var db = new TestHXContext())
            {
                List<DeviceTypeModel> list = db.DeviceType.ToList();
                return list;
            }
        }

        public IEnumerable<DeviceTypeModel> Get(Expression<Func<DeviceTypeModel, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DeviceTypeModel> Get<TOrderKey>(Expression<Func<DeviceTypeModel, bool>> filter, int pageIndex, int pageSize, Expression<Func<DeviceTypeModel, TOrderKey>> sortExpression, bool isAsc = true)
        {
            throw new NotImplementedException();
        }

        public void Update(DeviceTypeModel instance)
        {
            throw new NotImplementedException();
        }
    }
}
