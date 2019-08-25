using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class HallRepository:BaseRepository<Hall>
    {
        public Hall SelectByHallCode(string HallCode)
        {
            return _dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.Hall_Code == HallCode);
        }
    }
}
