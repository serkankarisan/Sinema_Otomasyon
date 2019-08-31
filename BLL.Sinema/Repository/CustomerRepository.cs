using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class CustomerRepository:BaseRepository<Customer>
    {
        public Customer SelectByPhone(string Phone)
        {
            return _dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.Phone == Phone);
        }
    }
}
