using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RoleToUserService
    {
        private readonly StudentDbContext _context;

        public RoleToUserService(StudentDbContext context)
        {
            _context = context;
        }
        public async Task<RoleToUser> GetById(int userId)
        {
            return _context.RoleToUsers.Include(x => x.Role).FirstOrDefault(x => x.UserID == userId);
        }
    }
}
