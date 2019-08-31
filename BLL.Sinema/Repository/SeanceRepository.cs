using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class SeanceRepository:BaseRepository<Seance>
    {
        public List<Seance> SelectByFilm(int MovieID)
        {
            return _dbSet.Where(w => w.IsActive == true && w.Movie.Id == MovieID).ToList();
        }
    }
}
