using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    public class Role : IAggregateRoot<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
