using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Test.Model
{
   public class MenuMapping:EntityTypeConfiguration<Menu>
    {
        public MenuMapping()
        {
            ToTable("Menu").HasKey(a => a.Id);

            HasMany(a => a.Roles).WithMany(a => a.Menus).Map(m => { m.ToTable("RoleMenu"); m.MapLeftKey("MenuId"); m.MapRightKey("RoleId"); });
        }
    }
}
