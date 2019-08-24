using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class User:EntityBase
    {
        private string _userName;
        private string _password;
        private string _name;
        private string _surName;

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public string Name { get => _name; set => _name = value; }
        public string SurName { get => _surName; set => _surName = value; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

    }
}
