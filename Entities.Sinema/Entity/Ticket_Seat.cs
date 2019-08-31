using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Ticket_Seat:EntityBase
    {
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }

        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }

    }
}
