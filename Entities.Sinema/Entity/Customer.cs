using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Sinema.Entity
{
    public class Customer:EntityBase
    {
        private string _name;
        private string _surname;
        private string _phone;
        [Column(Order = 3)]
        public string Name { get => _name; set => _name = value; }
        [Column(Order = 4)]
        public string Surname { get => _surname; set => _surname = value; }
        [Column(Order = 5)]
        public string Phone { get => _phone; set => _phone = value; }

        public virtual List<Ticket> Tickets { get; set; }
    }
}
