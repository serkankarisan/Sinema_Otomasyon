using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Hall:EntityBase
    {
        private string _hall_Code;
        private int _seating_Capacity;
        private int _max_Capacity;

        [Column(Order = 3)]
        public string Hall_Code { get => _hall_Code; set => _hall_Code = value; }
        [Column(Order = 4)]
        public int Seating_Capacity { get => _seating_Capacity; set => _seating_Capacity = value; }
        [Column(Order = 5)]
        public int Max_Capacity { get => _max_Capacity; set => _max_Capacity = value; }

        public virtual List<Seance> Seances { get; set; }
        public virtual List<Seat> Seats { get; set; }
    }
}
