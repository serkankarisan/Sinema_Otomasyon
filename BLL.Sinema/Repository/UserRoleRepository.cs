using DAL.Sinema.Context;
using Entities.Sinema.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Sinema.Repository
{
    public class UserRoleRepository
    {
        private SinemaContext _context;

        public UserRoleRepository()
        {
            _context = new SinemaContext();
        }

        protected int Save()
        {
            return _context.SaveChanges();
        }

        public int Insert(User_Role entity)
        {
            //entity.IsActive = true;
            //entity.AddedDate = DateTime.Now;
            _context.User_Roles.Add(entity);
            int result = _context.SaveChanges();
            return result;
        }

        public int Update(User_Role newVersion)
        {
            User_Role oldVersion = SelectById(newVersion.RoleId, newVersion.UserId);

            _context.Entry(oldVersion).CurrentValues.SetValues(newVersion);

            return Save();
        }

        public int Delete(int RoleId, int UserId)
        {
            User_Role deleted = SelectById(RoleId, UserId);

            _context.User_Roles.Remove(deleted);

            return Save();
        }

        public List<User_Role> Select()
        {
            return _context.User_Roles.Where(w => w.IsActive == true).ToList();
        }

        public List<User_Role> SelectWhere(Expression<Func<User_Role, bool>> predicate)
        {
            return _context.User_Roles.Where(predicate).Where(w => w.IsActive == true).ToList();
        }

        public User_Role SelectById(int RoleId, int UserId)
        {
            return _context.User_Roles.Where(w => w.IsActive == true).FirstOrDefault(x => x.RoleId == RoleId && x.UserId == UserId);
        }
    }
}
