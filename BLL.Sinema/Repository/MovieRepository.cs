using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class MovieRepository:BaseRepository<Movie>
    {
        public Movie SelectByMovieName(string MovieName)
        {
            return _dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.Movie_Name == MovieName);
        }
    }
}
