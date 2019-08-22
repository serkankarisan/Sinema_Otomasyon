using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Hall:EntityBase
    {
        private string _hall_Code;
        private int _seating_Capacity;

        public string Hall_Code { get => _hall_Code; set => _hall_Code = value; }
        public int Seating_Capacity { get => _seating_Capacity; set => _seating_Capacity = value; }
    }
}
