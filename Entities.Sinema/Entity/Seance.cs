using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Seance:EntityBase
    {
        private DateTime _start_Time;
        private DateTime _end_Time;

        [Column(Order = 3)]
        public DateTime Start_Time { get => _start_Time; set => _start_Time = value; }
        [Column(Order = 4)]
        public DateTime End_Time { get => _end_Time; set => _end_Time = value; }

        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }


        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }

        public virtual List<Ticket> Tickets { get; set; }
    }
}
