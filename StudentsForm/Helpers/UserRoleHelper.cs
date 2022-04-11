using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsForm.Helpers
{
    public static class UserRoleHelper
    {
        public static string getUserRole(int? UserId, List<RoleToUser> roleToUsers)
        {

            foreach (var item in roleToUsers)
            {
                if (item.UserID == UserId)
                {
                 
                    return item.Role.Name;
                }
            }
            return "Vəzifəsi Yoxdur";

        }
    }
}
