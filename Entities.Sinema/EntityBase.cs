using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema
{
    public class EntityBase
    {
        private int _id;
        private DateTime _addedDate;
        private bool _isActive;

        public int Id { get => _id; set => _id = value; }
        public DateTime AddedDate { get => _addedDate; set => _addedDate = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }
    }
}
