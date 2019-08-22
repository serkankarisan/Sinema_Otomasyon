﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Seat:EntityBase
    {
        private string _seat_Type;
        private decimal _price;

        public string Seat_Type { get => _seat_Type; set => _seat_Type = value; }
        public decimal Price { get => _price; set => _price = value; }

        public int HallId { get; set; }
        public virtual Hall Hall { get; set; }

        public virtual List<TicketDetail_Seat> TicketDetail_Seats { get; set; }
    }
}