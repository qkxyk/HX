using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Model;
using Test.Repository;

namespace Test.Service
{
    public class DeviceService : IService<DeviceModel>
    {
        private IRepository<DeviceModel, string> _device;
        public DeviceService(IRepository<DeviceModel, string> device)
        {
            _device = device;
        }
        public void Add(DeviceModel entity)
        {
            _device.Add(entity);
        }

        public IEnumerable<DeviceModel> Get()
        {
            return _device.Get();
        }

        public void Delete(DeviceModel entity)
        {
             _device.Delete(entity);
        }
    }
}
