using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class UserRepository:BaseRepository<User>
    {
        public User SelectByUserName(string UserName)
        {
            return _dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.UserName == UserName);
        }
    }
}
