using System;
using System.Collections.Generic;
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

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Phone { get => _phone; set => _phone = value; }

        public virtual List<Ticket> Tickets { get; set; }
    }
}
