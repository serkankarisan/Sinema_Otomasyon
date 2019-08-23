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

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }

        public virtual List<User_Role> User_Roles { get; set; }
    }
}
