using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Test.Model
{
    public class DevcieTypeModelMapping : EntityTypeConfiguration<DeviceTypeModel>
    {
        public DevcieTypeModelMapping()
        {
            ToTable("DeviceType").HasKey(a => a.Id);

            HasOptional(a => a.Parent).WithMany(a => a.Child).HasForeignKey(a => a.ParentId);
        }
    }
}
