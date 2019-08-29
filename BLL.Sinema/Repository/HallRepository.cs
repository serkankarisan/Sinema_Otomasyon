using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class HallRepository : BaseRepository<Hall>
    {
        public Hall SelectByHallCode(string HallCode)
        {
            return _dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.Hall_Code == HallCode);
        }
        public List<Hall> SelectBySeance(DateTime baslagic, DateTime bitis)
        {
            SeanceRepository Seances = new SeanceRepository();
            List<int> HallIDList = Seances.Select().Where(s => s.Start_Time >= baslagic && s.End_Time <= bitis).Select(w => w.HallId).ToList();
            List<Hall> List = _dbSet.Where(w => w.IsActive == true).ToList();
            foreach (int HallID in HallIDList)
            {
                List.Remove(_dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.Id != HallID));
            }
            return List;
        }
    }
}
