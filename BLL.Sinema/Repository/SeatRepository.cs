using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class SeatRepository:BaseRepository<Seat>
    {
        public Seat SelectBySeatCode(string SeatCode)
        {
            return _dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.Seat_Code == SeatCode);
        }
        public List<Seat> SelectByHallCode(string HallCode)
        {
            HallRepository Halls = new HallRepository();
            int HallID = Halls.SelectByHallCode(HallCode).Id;
            return _dbSet.Where(w => w.IsActive == true && w.HallId == HallID).ToList();
        }
    }
}
