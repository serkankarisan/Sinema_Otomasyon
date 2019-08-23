﻿using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class RoleRepository:BaseRepository<Role>
    {
        public Role SelectByRoleName(string RoleName)
        {
            return _dbSet.Where(w => w.IsActive == true).FirstOrDefault(x => x.RoleName == RoleName);
        }
    }
}
