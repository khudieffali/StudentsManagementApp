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
    public class UserService
    {
        private readonly StudentDbContext _context;

        public UserService(StudentDbContext context)
        {
            _context = context;
        }
         public async Task Add(User user)
        {
          await _context.AddAsync(user);
           await _context.SaveChangesAsync();
        }
         public async Task Update(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(User user)
        {
            user.IsDeleted = true;
            await _context.SaveChangesAsync();
        }
        public User GetByName(string username)
        {
           return _context.Users.Include(x=>x.RoleToUsers).ThenInclude(x=>x.Role).FirstOrDefault(x=>x.UserName==username);
        } 
    }
}
