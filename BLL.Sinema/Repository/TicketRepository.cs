using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class TicketRepository:BaseRepository<Ticket>
    {
        public Ticket SelectByTicketCode(string TicketCode)
        {
            return _dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.Ticket_Code == TicketCode);
    }
}
}
