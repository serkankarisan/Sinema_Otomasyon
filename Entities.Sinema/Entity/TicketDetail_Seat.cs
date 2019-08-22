using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class TicketDetail_Seat:EntityBase
    {
        public int TicketDetailId { get; set; }
        public int SeatId { get; set; }

    }
}
