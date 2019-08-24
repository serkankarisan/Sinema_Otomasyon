using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Role:EntityBase
    {
        private string _roleName;

        [Column(Order = 3)]
        public string RoleName { get => _roleName; set => _roleName = value; }

        public virtual List<User> Users { get; set; }

        public override string ToString()
        {
            return RoleName;
        }
    }
}
