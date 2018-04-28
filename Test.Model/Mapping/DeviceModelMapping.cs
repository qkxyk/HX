using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Test.Model
{
    public class DeviceModelMapping : EntityTypeConfiguration<DeviceModel>
    {
        public DeviceModelMapping()
        {
            ToTable("Device").HasKey(a => a.Id);

            HasOptional(a => a.DeviceType).WithMany(a => a.Device).HasForeignKey(a => a.TypeId).WillCascadeOnDelete(false);
        }
    }
}
