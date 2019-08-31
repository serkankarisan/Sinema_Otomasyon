using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Seat:EntityBase
    {
        private string _seat_Type;
        private int _location_X;
        private int _location_Y;

        [Column(Order = 3)]
        public string Seat_Code { get => _seat_Type; set => _seat_Type = value; }
        [Column(Order = 4)]
        public int Location_X { get => _location_X; set => _location_X = value; }
        [Column(Order = 5)]
        public int Location_Y { get => _location_Y; set => _location_Y = value; }

        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }

        public virtual List<Ticket_Seat> Ticket_Seats { get; set; }
        public Seat()
        {
            Location_X = 0;
            Location_Y = 0;
        }
    }
}
