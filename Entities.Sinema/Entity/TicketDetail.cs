using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class TicketDetail:EntityBase
    {
        public int TicketId { get; set; }
        public int SeatId { get; set; }
    }
}
