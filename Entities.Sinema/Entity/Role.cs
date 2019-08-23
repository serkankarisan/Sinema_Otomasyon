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

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
