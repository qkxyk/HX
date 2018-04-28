using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Test.Model
{
    public class UserRoleMapping : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMapping()
        {
            ToTable("UserRole").HasKey(t => new { t.UserId, t.RoleId });

            HasRequired(a => a.User).WithMany(a => a.UserRole).HasForeignKey(a => a.UserId);
            HasRequired(a => a.Role).WithMany(a => a.UserRole).HasForeignKey(a => a.RoleId);
        }
    }
}
