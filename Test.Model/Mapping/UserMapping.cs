using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Test.Model
{
  public  class UserMapping:EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable("User").HasKey(a => a.Id);
        }
    }
}
