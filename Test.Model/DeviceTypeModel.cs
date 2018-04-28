using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    public class DeviceTypeModel : IAggregateRoot<int>
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual DeviceTypeModel Parent { get; set; }
        public Nullable<int> ParentId { get; set; }
        public virtual ICollection<DeviceTypeModel> Child { get; set; }
        public virtual ICollection<DeviceModel> Device { get; set; }

    }
}
