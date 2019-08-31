using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Ticket:EntityBase
    {
        private DateTime _validity_Date;
        private decimal _ticket_Amount;
        private string _ticket_Code;
        [Column(Order = 3)]
        public string Ticket_Code { get => _ticket_Code; set => _ticket_Code = value; }
        [Column(Order = 4)]
        public DateTime Validity_Date { get => _validity_Date; set => _validity_Date = value; }
        [Column(Order = 5)]
        public decimal Ticket_Amount { get => _ticket_Amount; set => _ticket_Amount = value; }

        public int SeanceId { get; set; }
        public virtual Seance Seance { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual List<Ticket_Seat> Ticket_Seats { get; set; }
        
    }
}
