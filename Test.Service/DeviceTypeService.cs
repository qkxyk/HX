using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;
using Test.Repository;

namespace Test.Service
{
    public class DeviceTypeService : IService<DeviceTypeModel>
    {
        private IRepository<DeviceTypeModel, int> _deviceType;
        public DeviceTypeService(IRepository<DeviceTypeModel, int> deviceType)
        {
            _deviceType = deviceType;
        }

        public void Add(DeviceTypeModel entity)
        {
            _deviceType.Add(entity);
        }

        public IEnumerable<DeviceTypeModel> Get()
        {
            return _deviceType.Get();
        }

        public void Delete(DeviceTypeModel entity)
        {
            _deviceType.Delete(entity);
        }
    }
}
