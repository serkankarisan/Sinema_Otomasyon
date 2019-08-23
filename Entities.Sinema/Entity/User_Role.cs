using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class User_Role
    {
        private DateTime _addedDate;
        private bool _isActive;

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public DateTime AddedDate { get => _addedDate; set => _addedDate = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }

        public User_Role()
        {
            AddedDate = DateTime.Now;
            IsActive = true;
        }
    }
}
