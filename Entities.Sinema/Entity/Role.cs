using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Role:EntityBase
    {
        private string _roleName;

        public string RoleName { get => _roleName; set => _roleName = value; }

        public virtual List<User_Role> User_Roles { get; set; }
    }
}
