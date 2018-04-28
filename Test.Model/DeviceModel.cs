using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    public class DeviceModel : IAggregateRoot<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual DeviceTypeModel DeviceType { get; set; }
        public Nullable<int> TypeId { get; set; }
    }
}
