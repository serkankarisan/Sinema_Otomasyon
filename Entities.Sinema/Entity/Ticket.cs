using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Ticket:EntityBase
    {
        private DateTime _validity_Date;
        private decimal _ticket_Amount;

        public DateTime Validity_Date { get => _validity_Date; set => _validity_Date = value; }
        public decimal Ticket_Amount { get => _ticket_Amount; set => _ticket_Amount = value; }

        public int SeanceId { get; set; }
        public int CustomerId { get; set; }
    }
}
